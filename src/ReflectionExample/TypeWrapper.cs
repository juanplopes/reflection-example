using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

namespace ReflectionExample
{
    public class TypeWrapper
    {
        Type type;
        IList<PropertyWrapper> properties;
        Func<object> activator;

        public TypeWrapper(Type type)
        {
            this.type = type;
            this.properties = ExtractPropertiesFrom(type);
            Optimize(type);
        }

        private void Optimize(Type type)
        {
            this.activator = Expression.Lambda<Func<object>>(Expression.New(type)).Compile();
        }

        private static IList<PropertyWrapper> ExtractPropertiesFrom(Type type)
        {
            return type.GetProperties()
                .Select(x => new PropertyWrapper(x))
                .Where(x => x.IsValid).ToList();
        }

        public string WriteFrom(object instance)
        {
            var builder = new StringBuilder();
            foreach (var property in properties)
                property.WriteTo(builder, instance);
            return builder.ToString();
        }

        public object ReadFrom(string line)
        {
            var instance = activator();
            foreach (var property in properties)
                property.ReadFrom(line, instance);

            return instance;
        }
    }
}
