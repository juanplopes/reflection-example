using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Diagnostics;

namespace ReflectionExample
{
    [AttributeUsage(AttributeTargets.Property)]
    public class FieldAttribute : Attribute, IField
    {
        int start, end;
        int Size { get { return end - start; } }

        public FieldAttribute(int start, int end)
        {
            this.start = start - 1;
            this.end = end;
        }

public virtual void WriteTo(StringBuilder builder, object value)
{
    var stringValue = ConvertToString(value);

    builder.Length = Math.Max(builder.Length, end);
    WriteString(builder, stringValue);
    WriteSpaces(builder, stringValue);
}

protected virtual string ConvertToString(object value)
{
    return Convert.ToString(value, CultureInfo.InvariantCulture);
}

private void WriteString(StringBuilder builder, string stringValue)
{
    for (int i = 0; i < Math.Min(stringValue.Length, Size); i++)
        builder[start + i] = stringValue[i];
}

private void WriteSpaces(StringBuilder builder, string stringValue)
{

    for (int i = start + stringValue.Length; i < end; i++)
        builder[i] = ' ';
}

        public virtual object ReadFrom(string line, Type type)
        {
            var stringValue = line.Substring(start, Math.Min(line.Length - start, Size));
            stringValue = stringValue.Trim('\0', ' ');

            return ConvertFromString(stringValue, type);
        }

        protected virtual object ConvertFromString(string stringValue, Type type)
        {
            return Convert.ChangeType(stringValue, type, CultureInfo.InvariantCulture);
        }

        
    }
}
