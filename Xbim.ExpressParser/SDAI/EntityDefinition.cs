﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Attribute = Xbim.ExpressParser.SDAI.Attribute;

namespace Xbim.ExpressParser.SDAI
{
    public class EntityDefinition : NamedType
    {
        /// <summary>
        /// Usually just one supertype. Most of the OO programming languages don't 
        /// support multiple inheritance of concrete types.
        /// </summary>
        public HashSet<EntityDefinition> Supertypes { get; set; }

        /// <summary>
        /// Entity is complex if it refers to other entities (not as the inverse attributes).
        /// This can be set in SDAI schema but it is derived in this implementation
        /// </summary>
        public bool Complex
        {
            get { return AllExplicitAttributes.Any(a => IsEntityOrEntityAggregateType(a.Domain)); }
        }

        public bool Instantiable { get; set; }

        /// <summary>
        /// Entity is independent if it doesn't inherit from any other entity. It might still be
        /// part of selection. This value is derived in this implementation whereas it is possible to
        /// set it explicitly in original SDAI schema.
        /// </summary>
        public bool Independent {
            get { return Supertypes == null || !Supertypes.Any(); }
        }

        #region Inverse attributes

        public IEnumerable<Attribute> Attributes
        {
            get { return SchemaModel.Get<Attribute>(e => e.ParentEntity == this); }
        }

        /// <summary>
        /// This is an extension to SDAI schema but it should definitely be there
        /// </summary>
        public IEnumerable<UniquenessRule> UniquenessRules
        {
            get
            {
                return SchemaModel.Get<UniquenessRule>(e => e.ParentEntity == this);
            }
        }

        #endregion

        #region Extended inverse attributes

        public IEnumerable<Attribute> AllAttributes
        {
            get
            {
                //enumerate parent attributes first
                if (Supertypes != null)
                    foreach (var attribute in Supertypes.SelectMany(supertype => supertype.AllAttributes))
                    {
                        yield return attribute;
                    }
                foreach (var attribute in Attributes)
                {
                    yield return attribute;
                }
            }
        }

        /// <summary>
        /// Explicit attributes of this entity ordered by their occurance in the schema definition file.
        /// </summary>
        public IEnumerable<ExplicitAttribute> ExplicitAttributes
        {
            get { return SchemaModel.Get<ExplicitAttribute>(e => e.ParentEntity == this).OrderBy(a => a.Line); }
        }

        /// <summary>
        /// Explicit attributes including all inherited explicit attributes. All attributes are in the right
        /// order for serialization and/or deserialization (Ordered by their occurance in the schema file, inherited attributes first).
        /// </summary>
        public IEnumerable<ExplicitAttribute> AllExplicitAttributes
        {
            get
            {
                //enumerate parent attributes first
                if (Supertypes != null)
                    foreach (var attribute in Supertypes.SelectMany(supertype => supertype.AllExplicitAttributes))
                    {
                        yield return attribute;
                    }
                foreach (var attribute in ExplicitAttributes)
                {
                    yield return attribute;
                }
            }
        }
        #endregion

        public void AddAttribute(Attribute attribute)
        {
            attribute.ParentEntity = this;
            //make sure both live in the same model
            attribute.SchemaModel = SchemaModel;
        }


        #region Helper functions
        private bool IsEntityOrEntityAggregateType(BaseType t)
        {
            if (t is EntityDefinition) return true;
            //check if it is not an aggragation of entities (list, array, bag or set)
            return IsEntityAggregateType(t);
        }

        private bool IsEntityAggregateType(BaseType t)
        {
            var aggr = t as AggregationType;
            //this will make sure that it will also discover enumeration of enumerations
            return aggr != null && IsEntityOrEntityAggregateType(aggr.ElementType);
        }
        #endregion

    }
}