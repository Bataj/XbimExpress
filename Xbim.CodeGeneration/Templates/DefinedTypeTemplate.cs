﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 12.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Xbim.CodeGeneration.Templates
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\CODE\XbimGit\XbimExpress\Xbim.CodeGeneration\Templates\DefinedTypeTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public partial class DefinedTypeTemplate : DefinedTypeTemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("\r\n");
            
            #line 7 "C:\CODE\XbimGit\XbimExpress\Xbim.CodeGeneration\Templates\DefinedTypeTemplate.tt"
 foreach(var u in Using) { 
            
            #line default
            #line hidden
            this.Write("using ");
            
            #line 8 "C:\CODE\XbimGit\XbimExpress\Xbim.CodeGeneration\Templates\DefinedTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(u));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 9 "C:\CODE\XbimGit\XbimExpress\Xbim.CodeGeneration\Templates\DefinedTypeTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\nnamespace ");
            
            #line 11 "C:\CODE\XbimGit\XbimExpress\Xbim.CodeGeneration\Templates\DefinedTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n\t[ExpressType(\"");
            
            #line 13 "C:\CODE\XbimGit\XbimExpress\Xbim.CodeGeneration\Templates\DefinedTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Type.PersistanceName));
            
            #line default
            #line hidden
            this.Write("\", ");
            
            #line 13 "C:\CODE\XbimGit\XbimExpress\Xbim.CodeGeneration\Templates\DefinedTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Type.TypeId));
            
            #line default
            #line hidden
            this.Write(")]\r\n    // ReSharper disable once PartialTypeWithSinglePart\r\n\tpublic partial stru" +
                    "ct ");
            
            #line 15 "C:\CODE\XbimGit\XbimExpress\Xbim.CodeGeneration\Templates\DefinedTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Name));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 15 "C:\CODE\XbimGit\XbimExpress\Xbim.CodeGeneration\Templates\DefinedTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Inheritance));
            
            #line default
            #line hidden
            this.Write("\r\n\t{ \r\n\t\tprivate ");
            
            #line 17 "C:\CODE\XbimGit\XbimExpress\Xbim.CodeGeneration\Templates\DefinedTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(UnderlyingType));
            
            #line default
            #line hidden
            this.Write(" _value;\r\n        \r\n\t\tpublic object Value\r\n        {\r\n            get { return _v" +
                    "alue; }\r\n        }\r\n\r\n        public override string ToString()\r\n        {\r\n    " +
                    "        return Value != null ? Value.ToString() : typeof(");
            
            #line 26 "C:\CODE\XbimGit\XbimExpress\Xbim.CodeGeneration\Templates\DefinedTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(UnderlyingType));
            
            #line default
            #line hidden
            this.Write(").Name;\r\n        }\r\n\r\n        public ");
            
            #line 29 "C:\CODE\XbimGit\XbimExpress\Xbim.CodeGeneration\Templates\DefinedTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Name));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 29 "C:\CODE\XbimGit\XbimExpress\Xbim.CodeGeneration\Templates\DefinedTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(UnderlyingType));
            
            #line default
            #line hidden
            this.Write(" val)\r\n        {\r\n            _value = val;\r\n        }\r\n\r\n        public static i" +
                    "mplicit operator ");
            
            #line 34 "C:\CODE\XbimGit\XbimExpress\Xbim.CodeGeneration\Templates\DefinedTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Name));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 34 "C:\CODE\XbimGit\XbimExpress\Xbim.CodeGeneration\Templates\DefinedTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(UnderlyingType));
            
            #line default
            #line hidden
            this.Write(" value)\r\n        {\r\n            return new ");
            
            #line 36 "C:\CODE\XbimGit\XbimExpress\Xbim.CodeGeneration\Templates\DefinedTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Name));
            
            #line default
            #line hidden
            this.Write("(value);\r\n        }\r\n\r\n        public static implicit operator ");
            
            #line 39 "C:\CODE\XbimGit\XbimExpress\Xbim.CodeGeneration\Templates\DefinedTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(UnderlyingType));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 39 "C:\CODE\XbimGit\XbimExpress\Xbim.CodeGeneration\Templates\DefinedTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Name));
            
            #line default
            #line hidden
            this.Write(@" obj)
        {
            return obj._value;
        }


        public override bool Equals(object obj)
        {
			if (obj == null && Value == null)
                return true;

            if (obj == null)
                return false;

            if (GetType() != obj.GetType())
                return false;

");
            
            #line 56 "C:\CODE\XbimGit\XbimExpress\Xbim.CodeGeneration\Templates\DefinedTypeTemplate.tt"
	if (!IsComplex) { 
            
            #line default
            #line hidden
            this.Write("            return ((");
            
            #line 57 "C:\CODE\XbimGit\XbimExpress\Xbim.CodeGeneration\Templates\DefinedTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Name));
            
            #line default
            #line hidden
            this.Write(") obj)._value == _value;\r\n");
            
            #line 58 "C:\CODE\XbimGit\XbimExpress\Xbim.CodeGeneration\Templates\DefinedTypeTemplate.tt"
	} else { 
            
            #line default
            #line hidden
            this.Write("            return System.Linq.Enumerable.SequenceEqual(((");
            
            #line 59 "C:\CODE\XbimGit\XbimExpress\Xbim.CodeGeneration\Templates\DefinedTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Name));
            
            #line default
            #line hidden
            this.Write(") obj)._value, _value);\r\n");
            
            #line 60 "C:\CODE\XbimGit\XbimExpress\Xbim.CodeGeneration\Templates\DefinedTypeTemplate.tt"
	} 
            
            #line default
            #line hidden
            this.Write("        }\r\n\r\n        public static bool operator ==(");
            
            #line 63 "C:\CODE\XbimGit\XbimExpress\Xbim.CodeGeneration\Templates\DefinedTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Name));
            
            #line default
            #line hidden
            this.Write(" obj1, ");
            
            #line 63 "C:\CODE\XbimGit\XbimExpress\Xbim.CodeGeneration\Templates\DefinedTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Name));
            
            #line default
            #line hidden
            this.Write(" obj2)\r\n        {\r\n            return Equals(obj1, obj2);\r\n        }\r\n\r\n        p" +
                    "ublic static bool operator !=(");
            
            #line 68 "C:\CODE\XbimGit\XbimExpress\Xbim.CodeGeneration\Templates\DefinedTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Name));
            
            #line default
            #line hidden
            this.Write(" obj1, ");
            
            #line 68 "C:\CODE\XbimGit\XbimExpress\Xbim.CodeGeneration\Templates\DefinedTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Name));
            
            #line default
            #line hidden
            this.Write(" obj2)\r\n        {\r\n            return !Equals(obj1, obj2);\r\n        }\r\n\r\n        " +
                    "public override int GetHashCode()\r\n        {\r\n            return Value != null ?" +
                    " _value.GetHashCode() : base.GetHashCode();\r\n        }\r\n\r\n\t\t#region ");
            
            #line 78 "C:\CODE\XbimGit\XbimExpress\Xbim.CodeGeneration\Templates\DefinedTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(PersistInterface));
            
            #line default
            #line hidden
            this.Write(" implementation\r\n\t\tvoid ");
            
            #line 79 "C:\CODE\XbimGit\XbimExpress\Xbim.CodeGeneration\Templates\DefinedTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(PersistInterface));
            
            #line default
            #line hidden
            this.Write(".Parse(int propIndex, IPropertyValue value)\r\n\t\t{\r\n\t\t\tif (propIndex != 0)\r\n\t\t\t\tthr" +
                    "ow new XbimParserException(string.Format(\"Attribute index {0} is out of range fo" +
                    "r {1}\", propIndex + 1, GetType().Name.ToUpper()));\r\n");
            
            #line 83 "C:\CODE\XbimGit\XbimExpress\Xbim.CodeGeneration\Templates\DefinedTypeTemplate.tt"
	if (IsComplex) { 
            
            #line default
            #line hidden
            this.Write("\t\t\tif (_value == null)\r\n\t\t\t\t_value = new ");
            
            #line 85 "C:\CODE\XbimGit\XbimExpress\Xbim.CodeGeneration\Templates\DefinedTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(UnderlyingType));
            
            #line default
            #line hidden
            this.Write("();\r\n");
            
            #line 86 "C:\CODE\XbimGit\XbimExpress\Xbim.CodeGeneration\Templates\DefinedTypeTemplate.tt"
		if (IsComplexOfEntities) { 
            
            #line default
            #line hidden
            this.Write("            _value.Add(value.");
            
            #line 87 "C:\CODE\XbimGit\XbimExpress\Xbim.CodeGeneration\Templates\DefinedTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetPropertyValueMember(Type.Domain)));
            
            #line default
            #line hidden
            this.Write(" as ");
            
            #line 87 "C:\CODE\XbimGit\XbimExpress\Xbim.CodeGeneration\Templates\DefinedTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(UnderlyingArrayType));
            
            #line default
            #line hidden
            this.Write(");\r\n");
            
            #line 88 "C:\CODE\XbimGit\XbimExpress\Xbim.CodeGeneration\Templates\DefinedTypeTemplate.tt"
		} else { 
            
            #line default
            #line hidden
            this.Write("            _value.Add(value.");
            
            #line 89 "C:\CODE\XbimGit\XbimExpress\Xbim.CodeGeneration\Templates\DefinedTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetPropertyValueMember(Type.Domain)));
            
            #line default
            #line hidden
            this.Write(");\r\n");
            
            #line 90 "C:\CODE\XbimGit\XbimExpress\Xbim.CodeGeneration\Templates\DefinedTypeTemplate.tt"
		} 
            
            #line default
            #line hidden
            
            #line 91 "C:\CODE\XbimGit\XbimExpress\Xbim.CodeGeneration\Templates\DefinedTypeTemplate.tt"
	} 
	else { 
            
            #line default
            #line hidden
            this.Write("            _value = value.");
            
            #line 93 "C:\CODE\XbimGit\XbimExpress\Xbim.CodeGeneration\Templates\DefinedTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetPropertyValueMember(Type.Domain)));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 94 "C:\CODE\XbimGit\XbimExpress\Xbim.CodeGeneration\Templates\DefinedTypeTemplate.tt"
	}
            
            #line default
            #line hidden
            this.Write("            \r\n\t\t}\r\n\r\n\t\tstring ");
            
            #line 97 "C:\CODE\XbimGit\XbimExpress\Xbim.CodeGeneration\Templates\DefinedTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(PersistInterface));
            
            #line default
            #line hidden
            this.Write(".WhereRule()\r\n\t\t{\r\n            throw new System.NotImplementedException();\r\n\t\t}\r\n" +
                    "\t\t#endregion\r\n\r\n\t\t#region IExpressValueType implementation\r\n        System.Type " +
                    "IExpressValueType.UnderlyingSystemType { \r\n\t\t\tget \r\n\t\t\t{\r\n\t\t\t\treturn typeof(");
            
            #line 107 "C:\CODE\XbimGit\XbimExpress\Xbim.CodeGeneration\Templates\DefinedTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(UnderlyingType));
            
            #line default
            #line hidden
            this.Write(");\r\n\t\t\t}\r\n\t\t}\r\n\t\t#endregion\r\n\r\n");
            
            #line 112 "C:\CODE\XbimGit\XbimExpress\Xbim.CodeGeneration\Templates\DefinedTypeTemplate.tt"
 if (IsComplex) { 
            
            #line default
            #line hidden
            this.Write(@"		#region IExpressComplexType implementation
		IEnumerable<object> IExpressComplexType.Properties
        {
            get
            {
				if(_value == null) yield break;
	            foreach (var value in _value)
	                yield return value;
            }
        }

		void IExpressComplexType.Add(object o)
	    {
			if (_value == null)
				_value = new ");
            
            #line 127 "C:\CODE\XbimGit\XbimExpress\Xbim.CodeGeneration\Templates\DefinedTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(UnderlyingType));
            
            #line default
            #line hidden
            this.Write("();\r\n\t\t\t _value.Add((");
            
            #line 128 "C:\CODE\XbimGit\XbimExpress\Xbim.CodeGeneration\Templates\DefinedTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(UnderlyingArrayType));
            
            #line default
            #line hidden
            this.Write(") o);\r\n\t    }\r\n\t\t#endregion\r\n");
            
            #line 131 "C:\CODE\XbimGit\XbimExpress\Xbim.CodeGeneration\Templates\DefinedTypeTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n\t}\r\n}\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public class DefinedTypeTemplateBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
