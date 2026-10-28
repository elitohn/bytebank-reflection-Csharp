using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Common;

[AttributeUsage(AttributeTargets.Property)]
public class NomeColunaAttribute : Attribute
{
    public string Header { get; }

    public NomeColunaAttribute(string header)
    {
        Header = header;
    }
}
