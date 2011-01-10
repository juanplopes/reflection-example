using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace ReflectionExample
{
    public class PropertyWrapper
    {
        private PropertyInfo property;
        private IField fieldDescriptor;
        
        public bool IsValid { get { return fieldDescriptor != null; } }
        public string Name { get { return property.Name; } }

        public PropertyWrapper(PropertyInfo property)
        {
            this.property = property;
            this.fieldDescriptor = ExtractFieldAttribute(property);
        }

        private static IField ExtractFieldAttribute(PropertyInfo property)
        {
            return property.GetCustomAttributes(typeof(IField), true).OfType<IField>().FirstOrDefault();
        }

        public void WriteTo(StringBuilder builder, object instance)
        {
            var value = property.GetValue(instance, null);
            fieldDescriptor.WriteTo(builder, value);
        }

        public void ReadFrom(string line, object instance)
        {
            var value = fieldDescriptor.ReadFrom(line, property.PropertyType);
            property.SetValue(instance, value, null);
        }
    }
}
