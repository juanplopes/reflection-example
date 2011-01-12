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
            writer.WriteLine(type.WriteFrom(obj));
        }

        public IEnumerable ReadAll(TextReader reader)
        {
            var list = new List<object>();
            for (object obj = Read(reader); obj != null; obj = Read(reader))
                list.Add(obj);

            return list;
        }

        public object Read(TextReader reader)
        {
            var line = reader.ReadLine();
            if (line == null) return null;

            return type.ReadFrom(line);
        }
    }
}

