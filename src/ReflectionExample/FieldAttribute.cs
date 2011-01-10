using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace ReflectionExample
{
    public class FieldAttribute : Attribute, IField
    {
        int start, end;
        int Size { get { return end - start; } }
        public bool Trim { get; set; }

        public FieldAttribute(int start, int end)
        {
            this.start = start - 1;
            this.end = end;
            Trim = true;
        }

        public virtual void WriteTo(StringBuilder builder, object value)
        {
            var stringValue = Convert.ToString(value);

            builder.Length = Math.Max(builder.Length, end);

            WriteString(builder, stringValue);
            WriteSpaces(builder, stringValue);
        }

        public virtual object ReadFrom(string line, Type type)
        {
            var stringValue = line.Substring(start, Math.Min(line.Length - start, Size));
            if (Trim) stringValue = stringValue.Trim('\0', ' ');
            
            return Convert.ChangeType(stringValue, type);
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
    }
}
