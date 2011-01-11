using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Collections;

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

        public void WriteAll(TextWriter writer, IEnumerable objs)
        {
            foreach (var obj in objs)
                Write(writer, obj);
        }

        public void Write(TextWriter writer, object obj)
        {
            var builder = new StringBuilder();
            foreach (var property in type.Properties)
                property.WriteTo(builder, obj);

            writer.WriteLine(builder);
        }

        public IEnumerable ReadAll(TextReader writer)
        {
            for (object obj = Read(writer); obj != null; obj = Read(writer))
                yield return obj;
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

