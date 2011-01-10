﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace ReflectionExample
{
    public class FixedColumnsSerializer
    {
        TypeWrapper type;
        protected TypeWrapper Type { get { return type; } }

        public FixedColumnsSerializer(Type type)
        {
            this.type = new TypeWrapper(type);
        }

        public void Write(TextWriter writer, object obj)
        {
            var builder = new StringBuilder();
            foreach (var property in type.Properties)
                property.WriteTo(builder, obj);

            writer.WriteLine(builder);
        }

        public object Read(TextReader reader)
        {
            var line = reader.ReadLine();
            if (line == null) return null;

            var obj = type.CreateInstance();
            foreach (var property in type.Properties)
                property.ReadFrom(line, obj);

            return obj;
        }
    }
}
