﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 12.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Xbim.CodeGeneration.Templates.Infrastructure
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\CODE\XbimGit\XbimExpress\Xbim.CodeGeneration\Templates\Infrastructure\ItemSetTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public partial class ItemSetTemplate : ItemSetTemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("\r\nusing System;\r\nusing System.Collections;\r\nusing System.Collections.Generic;\r\nus" +
                    "ing System.Collections.Specialized;\r\nusing System.ComponentModel;\r\nusing System." +
                    "Linq;\r\n");
            
            #line 13 "C:\CODE\XbimGit\XbimExpress\Xbim.CodeGeneration\Templates\Infrastructure\ItemSetTemplate.tt"
 foreach(var u in Using) { 
            
            #line default
            #line hidden
            this.Write("using ");
            
            #line 14 "C:\CODE\XbimGit\XbimExpress\Xbim.CodeGeneration\Templates\Infrastructure\ItemSetTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(u));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 15 "C:\CODE\XbimGit\XbimExpress\Xbim.CodeGeneration\Templates\Infrastructure\ItemSetTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\nnamespace ");
            
            #line 17 "C:\CODE\XbimGit\XbimExpress\Xbim.CodeGeneration\Templates\Infrastructure\ItemSetTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    public class ");
            
            #line 19 "C:\CODE\XbimGit\XbimExpress\Xbim.CodeGeneration\Templates\Infrastructure\ItemSetTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Name));
            
            #line default
            #line hidden
            this.Write("<T> : I");
            
            #line 19 "C:\CODE\XbimGit\XbimExpress\Xbim.CodeGeneration\Templates\Infrastructure\ItemSetTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Name));
            
            #line default
            #line hidden
            this.Write("<T>\r\n    {\r\n        private readonly List<T> _set;\r\n        private readonly ");
            
            #line 22 "C:\CODE\XbimGit\XbimExpress\Xbim.CodeGeneration\Templates\Infrastructure\ItemSetTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ModelInterface));
            
            #line default
            #line hidden
            this.Write(" _model;\r\n\r\n\t\tpublic ");
            
            #line 24 "C:\CODE\XbimGit\XbimExpress\Xbim.CodeGeneration\Templates\Infrastructure\ItemSetTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(PersistEntityInterface));
            
            #line default
            #line hidden
            this.Write(" OwningEntity { get; private set; }\r\n\r\n        protected List<T> Internal\r\n      " +
                    "  {\r\n            get { return _set; }\r\n        }\r\n\r\n\r\n        internal ");
            
            #line 32 "C:\CODE\XbimGit\XbimExpress\Xbim.CodeGeneration\Templates\Infrastructure\ItemSetTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Name));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 32 "C:\CODE\XbimGit\XbimExpress\Xbim.CodeGeneration\Templates\Infrastructure\ItemSetTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(PersistEntityInterface));
            
            #line default
            #line hidden
            this.Write(" entity)\r\n        {\r\n            _set = new List<T>();\r\n            _model = enti" +
                    "ty.Model;\r\n\t\t\tOwningEntity = entity;\r\n        }\r\n\r\n\t\tinternal ");
            
            #line 39 "C:\CODE\XbimGit\XbimExpress\Xbim.CodeGeneration\Templates\Infrastructure\ItemSetTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Name));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 39 "C:\CODE\XbimGit\XbimExpress\Xbim.CodeGeneration\Templates\Infrastructure\ItemSetTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(PersistEntityInterface));
            
            #line default
            #line hidden
            this.Write(" entity, int count)\r\n        {\r\n            _set = new List<T>(count);\r\n         " +
                    "   _model = entity.Model;\r\n\t\t\tOwningEntity = entity;\r\n        }\r\n\r\n        inter" +
                    "nal ");
            
            #line 46 "C:\CODE\XbimGit\XbimExpress\Xbim.CodeGeneration\Templates\Infrastructure\ItemSetTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Name));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 46 "C:\CODE\XbimGit\XbimExpress\Xbim.CodeGeneration\Templates\Infrastructure\ItemSetTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(PersistEntityInterface));
            
            #line default
            #line hidden
            this.Write(@" entity, IEnumerable<T> collection)
        {
            _set = new List<T>(collection);
            _model = entity.Model;
			OwningEntity = entity;
        }

		//this is to be only used internaly to add object outside of any transaction or event firing
		//that is typically during parsing operation
		internal void InternalAdd(T value)
		{
			Internal.Add(value);
		}

        #region I");
            
            #line 60 "C:\CODE\XbimGit\XbimExpress\Xbim.CodeGeneration\Templates\Infrastructure\ItemSetTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Name));
            
            #line default
            #line hidden
            this.Write("<T> Members\r\n        public T First\r\n        {\r\n            get { return Internal" +
                    ".First(); }\r\n        }\r\n\r\n        public T FirstOrDefault()\r\n        {\r\n        " +
                    "    return Internal.FirstOrDefault();\r\n        }\r\n\r\n        public T FirstOrDefa" +
                    "ult(Func<T, bool> predicate)\r\n        {\r\n            return Internal.FirstOrDefa" +
                    "ult(predicate);\r\n        }\r\n\r\n        public TF FirstOrDefault<TF>(Func<TF, bool" +
                    "> predicate)\r\n        {\r\n            return OfType<TF>().FirstOrDefault(predicat" +
                    "e);\r\n        }\r\n\r\n        public IEnumerable<TW> Where<TW>(Func<TW, bool> predic" +
                    "ate)\r\n        {\r\n            return OfType<TW>().Where(predicate);\r\n        }\r\n\r" +
                    "\n        public IEnumerable<TO> OfType<TO>()\r\n        {\r\n            return Inte" +
                    "rnal.Count == 0 ? Enumerable.Empty<TO>() : Internal.OfType<TO>();\r\n        }\r\n  " +
                    "      #endregion\r\n\r\n        #region INotifyPropertyChanged Members\r\n\r\n        pu" +
                    "blic event PropertyChangedEventHandler PropertyChanged;\r\n\r\n        [NonSerialize" +
                    "d]\r\n        private readonly PropertyChangedEventArgs _countPropChangedEventArgs" +
                    " =\r\n            new PropertyChangedEventArgs(\"Count\");\r\n\r\n        private void N" +
                    "otifyCountChanged(int oldValue)\r\n        {\r\n            var propChanged = Proper" +
                    "tyChanged;\r\n            if (propChanged != null && oldValue != Internal.Count)\r\n" +
                    "                propChanged(this, _countPropChangedEventArgs);\r\n        }\r\n\r\n   " +
                    "     #endregion\r\n\r\n        #region INotifyCollectionChanged Members\r\n\r\n        p" +
                    "ublic event NotifyCollectionChangedEventHandler CollectionChanged;\r\n\r\n        #e" +
                    "ndregion\r\n\r\n        #region ICollection<T> Members\r\n\r\n        public virtual voi" +
                    "d Add(T item)\r\n        {\r\n            if(_model.IsTransactional && _model.Curren" +
                    "tTransaction == null)\r\n                throw new Exception(\"Operation out of tra" +
                    "nsaction\");\r\n\r\n            var oldCount = Internal.Count;\r\n            Internal." +
                    "Add(item);\r\n\r\n            if (_model.IsTransactional)\r\n            {\r\n          " +
                    "      Action undoAction = () => Internal.Remove(item);\r\n                Action d" +
                    "oAction = () => Internal.Add(item);\r\n                _model.CurrentTransaction.A" +
                    "ddReversibleAction(doAction, undoAction, OwningEntity, ChangeType.Modified);\r\n  " +
                    "          }\r\n\r\n            if (CollectionChanged != null)\r\n                Colle" +
                    "ctionChanged(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedA" +
                    "ction.Add, item));\r\n\r\n            NotifyCountChanged(oldCount);\r\n        }\r\n\r\n\r\n" +
                    "        public virtual void Clear()\r\n        {\r\n            if (_model.IsTransac" +
                    "tional && _model.CurrentTransaction == null)\r\n                throw new Exceptio" +
                    "n(\"Operation out of transaction\");\r\n\r\n            var oldCount = Count;\r\n       " +
                    "     Internal.Clear();\r\n            \r\n            if (_model.IsTransactional)\r\n " +
                    "           {\r\n                var oldItems = Internal.ToArray();\r\n              " +
                    "  Action doAction = () => Internal.Clear();\r\n                Action undoAction =" +
                    " () => Internal.AddRange(oldItems);\r\n                _model.CurrentTransaction.A" +
                    "ddReversibleAction(doAction, undoAction, OwningEntity, ChangeType.Modified);\r\n  " +
                    "          }\r\n\r\n            if (CollectionChanged != null)\r\n                Colle" +
                    "ctionChanged(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedA" +
                    "ction.Reset));\r\n\r\n            NotifyCountChanged(oldCount);\r\n        }\r\n\r\n      " +
                    "  public bool Contains(T item)\r\n        {\r\n            return Internal.Contains(" +
                    "item);\r\n        }\r\n\r\n        public void CopyTo(T[] array, int arrayIndex)\r\n    " +
                    "    {\r\n            Internal.CopyTo(array, arrayIndex);\r\n        }\r\n\r\n        pub" +
                    "lic int Count\r\n        {\r\n            get { return Internal.Count; }\r\n        }\r" +
                    "\n\r\n\r\n        public virtual bool Remove(T item)\r\n        {\r\n            if (_mod" +
                    "el.IsTransactional && _model.CurrentTransaction == null)\r\n                throw " +
                    "new Exception(\"Operation out of transaction\");\r\n\r\n            var oldCount = Int" +
                    "ernal.Count;\r\n            var removed = Internal.Remove(item);\r\n            if (" +
                    "!removed) return false;\r\n\r\n            if (_model.IsTransactional)\r\n            " +
                    "{\r\n                Action doAction = () => Internal.Remove(item);\r\n             " +
                    "   Action undoAction = () => Internal.Add(item);\r\n                _model.Current" +
                    "Transaction.AddReversibleAction(doAction, undoAction, OwningEntity, ChangeType.M" +
                    "odified);\r\n            }\r\n\r\n            if (CollectionChanged != null)\r\n        " +
                    "        CollectionChanged(this, new NotifyCollectionChangedEventArgs(NotifyColle" +
                    "ctionChangedAction.Remove, item));\r\n\r\n            NotifyCountChanged(oldCount);\r" +
                    "\n            return true;\r\n        }\r\n\r\n        #endregion\r\n\r\n        #region IE" +
                    "numerable<T> Members\r\n\r\n        public IEnumerator<T> GetEnumerator()\r\n        {" +
                    "\r\n            return Internal.Count == 0 ? Enumerable.Empty<T>().GetEnumerator()" +
                    " : Internal.GetEnumerator();\r\n        }\r\n\r\n        #endregion\r\n\r\n        #region" +
                    " IEnumerable Members\r\n\r\n        IEnumerator IEnumerable.GetEnumerator()\r\n       " +
                    " {\r\n            return Internal.Count == 0 ? Enumerable.Empty<T>().GetEnumerator" +
                    "() : Internal.GetEnumerator();\r\n        }\r\n\r\n        #endregion\r\n\r\n        #regi" +
                    "on ICollection<T> Members\r\n\r\n        void ICollection<T>.Add(T item)\r\n        {\r" +
                    "\n            Add(item);\r\n        }\r\n\r\n        void ICollection<T>.Clear()\r\n     " +
                    "   {\r\n            Clear();\r\n        }\r\n\r\n        bool ICollection<T>.Contains(T " +
                    "item)\r\n        {\r\n            return Internal.Contains(item);\r\n        }\r\n\r\n    " +
                    "    void ICollection<T>.CopyTo(T[] array, int arrayIndex)\r\n        {\r\n          " +
                    "  Internal.CopyTo(array, arrayIndex);\r\n        }\r\n\r\n        int ICollection<T>.C" +
                    "ount\r\n        {\r\n            get { return Count; }\r\n        }\r\n\r\n        bool IC" +
                    "ollection<T>.IsReadOnly\r\n        {\r\n            get { return ((IList<T>)Internal" +
                    ").IsReadOnly; }\r\n        }\r\n\r\n        bool ICollection<T>.Remove(T item)\r\n      " +
                    "  {\r\n            return Remove(item);\r\n        }\r\n\r\n        #endregion\r\n\r\n      " +
                    "  #region ICollection Members\r\n\r\n        void ICollection.CopyTo(Array array, in" +
                    "t index)\r\n        {\r\n            CopyTo((T[])array, index);\r\n        }\r\n\r\n      " +
                    "  int ICollection.Count\r\n        {\r\n            get { return Internal.Count; }\r\n" +
                    "        }\r\n\r\n        bool ICollection.IsSynchronized\r\n        {\r\n            get" +
                    " { return ((ICollection)Internal).IsSynchronized; }\r\n        }\r\n\r\n        object" +
                    " ICollection.SyncRoot\r\n        {\r\n            get { return ((ICollection)Interna" +
                    "l).SyncRoot; }\r\n        }\r\n\r\n        #endregion\r\n\r\n\t\t#region IList<T> members\r\n\t" +
                    "\tpublic T this[int index]\r\n\t\t{\r\n\t\t    get\r\n\t\t    {\r\n\t\t        return Internal[in" +
                    "dex];\r\n\t\t    }\r\n\t\t    set\r\n\t\t    {\r\n\t\t\t\tif(_model.IsTransactional && _model.Curr" +
                    "entTransaction == null)\r\n\t\t\t\t    throw new Exception(\"Operation out of transacti" +
                    "on\");\r\n\r\n\t\t\t\tvar oldValue = Internal[index];\r\n\t\t        Internal[index] = value;" +
                    "\r\n\r\n\t\t\t\tif (_model.IsTransactional)\r\n\t\t\t\t{\r\n\t\t\t\t    Action doAction = () => Inte" +
                    "rnal[index] = value;\r\n\t\t\t\t    Action undoAction = () => Internal[index] = oldVal" +
                    "ue;\r\n\t\t\t\t    _model.CurrentTransaction.AddReversibleAction(doAction, undoAction," +
                    " OwningEntity, ChangeType.Modified);\r\n\t\t\t\t}\r\n\r\n\t\t\t\tif (CollectionChanged != null" +
                    ")\r\n\t\t\t\t    CollectionChanged(this, new NotifyCollectionChangedEventArgs(NotifyCo" +
                    "llectionChangedAction.Replace, value));\r\n\r\n\t\t    }\r\n\t\t}\r\n\r\n\t\tpublic int IndexOf(" +
                    "T item)\r\n\t\t{\r\n\t\t\treturn Internal.IndexOf(item);\r\n\t\t}\r\n\r\n\r\n        public void In" +
                    "sert(int index, T item)\r\n        {\r\n            if (_model.IsTransactional && _m" +
                    "odel.CurrentTransaction == null)\r\n                throw new Exception(\"Operation" +
                    " out of transaction\");\r\n\r\n            var oldCount = Internal.Count;\r\n          " +
                    "  Internal.Insert(index, item);\r\n\r\n            if (_model.IsTransactional)\r\n    " +
                    "        {\r\n                Action undoAction = () => Internal.RemoveAt(index);\r\n" +
                    "                Action doAction = () => Internal.Insert(index, item);\r\n         " +
                    "       _model.CurrentTransaction.AddReversibleAction(doAction, undoAction, Ownin" +
                    "gEntity, ChangeType.Modified);\r\n            }\r\n\r\n            if (CollectionChang" +
                    "ed != null)\r\n                CollectionChanged(this, new NotifyCollectionChanged" +
                    "EventArgs(NotifyCollectionChangedAction.Add, item));\r\n\r\n            NotifyCountC" +
                    "hanged(oldCount);\r\n        }\r\n\r\n        public void RemoveAt(int index)\r\n       " +
                    " {\r\n            var toRemove = Internal[index];\r\n            Remove(toRemove);\r\n" +
                    "        }\r\n        #endregion\r\n\r\n        #region IList members\r\n        int ILis" +
                    "t.Add(object value)\r\n        {\r\n            if (!(value is T)) return -1;\r\n\r\n   " +
                    "         var v = (T) value;\r\n            Add(v);\r\n            return Internal.Co" +
                    "unt - 1;\r\n        }\r\n\r\n        bool IList.Contains(object value)\r\n        {\r\n   " +
                    "         return ((IList)Internal).Contains(value);\r\n        }\r\n\r\n        int ILi" +
                    "st.IndexOf(object value)\r\n        {\r\n            return ((IList)Internal).IndexO" +
                    "f(value);\r\n        }\r\n\r\n        void IList.Insert(int index, object value)\r\n    " +
                    "    {\r\n            Insert(index, (T)value);\r\n        }\r\n\r\n        bool IList.IsF" +
                    "ixedSize\r\n        {\r\n            get { return false; }\r\n        }\r\n\r\n        boo" +
                    "l IList.IsReadOnly\r\n        {\r\n            get { return _model.IsTransactional &" +
                    "& _model.CurrentTransaction != null; }\r\n        }\r\n\r\n        void IList.Remove(o" +
                    "bject value)\r\n        {\r\n            Remove((T)value);\r\n        }\r\n\r\n        obj" +
                    "ect IList.this[int index]\r\n        {\r\n            get\r\n            {\r\n          " +
                    "      return this[index];\r\n            }\r\n            set\r\n            {\r\n      " +
                    "          this[index] = value == null ? default(T) : (T)value;\r\n            }\r\n " +
                    "       }\r\n        #endregion\r\n    }\r\n}\r\n");
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
    public class ItemSetTemplateBase
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
