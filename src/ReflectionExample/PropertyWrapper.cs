﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Linq.Expressions;

namespace ReflectionExample
{
    public class PropertyWrapper
    {
        private PropertyInfo property;
        private IField fieldDescriptor;
        private Func<object, object> getFrom;
        private Action<object, object> setTo;

        public bool IsValid { get { return fieldDescriptor != null; } }
        public string Name { get { return property.Name; } }

        public PropertyWrapper(PropertyInfo property)
        {
            this.property = property;
            this.fieldDescriptor = ExtractFieldAttributeFrom(property);
            if (IsValid)
                Optimize(property);
        }

        private static IField ExtractFieldAttributeFrom(PropertyInfo property)
        {
            return property.GetCustomAttributes(typeof(IField), true)
                .OfType<IField>().FirstOrDefault();
        }

        private void Optimize(PropertyInfo property)
        {
            var target = Expression.Parameter(typeof(object));
            var value = Expression.Parameter(typeof(object));
            var prop = Expression.Property
                (Expression.Convert(target, property.DeclaringType), property);

            this.getFrom = Expression.Lambda<Func<object, object>>(Expression.Convert(
                prop, typeof(object)), target).Compile();
            this.setTo = Expression.Lambda<Action<object, object>>(Expression.Assign(
                prop, Expression.Convert(value, property.PropertyType)), target, value).Compile();
        }

        public void WriteTo(StringBuilder builder, object instance)
        {
            fieldDescriptor.WriteTo(builder, getFrom(instance));
        }

        public void ReadFrom(string line, object instance)
        {
            setTo(instance,
                fieldDescriptor.ReadFrom(line, property.PropertyType));
        }
    }
}
