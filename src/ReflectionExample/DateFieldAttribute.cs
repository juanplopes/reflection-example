using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace ReflectionExample
{
    [AttributeUsage(AttributeTargets.Property)]
    public class DateFieldAttribute : FieldAttribute
    {
        string format;

        public DateFieldAttribute(int start, int end) : this(start, end, null) { }
        public DateFieldAttribute(int start, int end, string format)
            : base(start, end)
        {
            this.format = format;
        }

        protected override object ConvertFromString(Type type, string stringValue)
        {
            if (format != null)
                return DateTime.ParseExact(stringValue, format, CultureInfo.InvariantCulture);
            else
                return DateTime.Parse(stringValue, CultureInfo.InvariantCulture);
        }

        protected override string ConvertToString(object value)
        {
            return ((DateTime)value).ToString(format, CultureInfo.InvariantCulture);
        }
    }
}
