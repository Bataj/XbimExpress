﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xbim.ExpressParser.SDAI
{
    public class SelectType:SchemaEntity, ConstructedType
    {
        public List<NamedType> Selections { get; set; }
    }
}
