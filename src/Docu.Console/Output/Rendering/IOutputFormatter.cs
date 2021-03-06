﻿using System.Collections.Generic;
using Docu.Documentation;
using Docu.Documentation.Comments;

namespace Docu.Output.Rendering
{
    public interface IOutputFormatter
    {
        string NamespaceUrlFormat { get; set; }
        string TypeUrlFormat { get; set; }
        string MethodUrlFormat { get; set; }
        string PropertyUrlFormat { get; set; }
        string FieldUrlFormat { get; set; }
        string EventUrlFormat { get; set; }
        string Format(IComment comment);
        string FormatReferencable(IReferencable referencable);
        string FormatReferencable(IReferencable referencable, IEnumerable<KeyValuePair<string, string>> attributes);
        string Escape(string value);
    }
}