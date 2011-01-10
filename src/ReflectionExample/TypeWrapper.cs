using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReflectionExample
{
    public class TypeWrapper
    {
        Type type;
        IList<PropertyWrapper> properties;
        public IEnumerable<PropertyWrapper> Properties
        {
            get { return properties; }
        }

        public TypeWrapper(Type type)
        {
            this.type = type;
            this.properties = ExtractPropreries(type);
        }

        private static IList<PropertyWrapper> ExtractPropreries(Type type)
        {
            return type.GetProperties()
                .Select(x => new PropertyWrapper(x))
                .Where(x => x.IsValid).ToList();
        }

        public object CreateInstance()
        {
            return Activator.CreateInstance(type);
        }
    }
}
