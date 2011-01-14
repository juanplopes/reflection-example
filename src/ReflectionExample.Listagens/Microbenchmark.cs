using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;
using System.Linq.Expressions;
using System.Diagnostics;
using System.Runtime.Serialization.Formatters.Binary;

namespace ReflectionExample.Listagens
{
    public class Microbenchmark
    {
        [Serializable]
        public class Remessa
        {
            [Field(1, 5)]
            public int BancoOrigem { get; set; }
            [Field(6, 10)]
            public int AgenciaOrigem { get; set; }
            [Field(11, 20)]
            public int ContaOrigem { get; set; }

            [Field(21, 25)]
            public int BancoDestino { get; set; }
            [Field(26, 30)]
            public int AgenciaDestino { get; set; }
            [Field(31, 40)]
            public int ContaDestino { get; set; }

            [Field(41, 50)]
            public decimal Valor { get; set; }
            [Field(51, 60)]
            public DateTime Data { get; set; }
        }

        public static void Test()
        {
            var obj = new Remessa();
            var s = new Stopwatch();
            
            var serializer1 = new FixedColumnsSerializer(typeof(Remessa));
            var writer1 = new StringWriter();
            s.Restart();
            for (int i = 0; i < 1000000; i++)
                serializer1.Write(writer1, obj);
            Console.WriteLine(s.Elapsed);


            var writer2 = new MemoryStream((int)1e8);
            var serializer2 = new BinaryFormatter();
            s.Restart();
            for (int i = 0; i < 1000000; i++)
                serializer2.Serialize(writer2, obj);
            Console.WriteLine(s.Elapsed);
        }
    }
}
