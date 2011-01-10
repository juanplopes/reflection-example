using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;

namespace ReflectionExample.Listagens
{
    public class Listagem0B
    {
        public static void Test()
        {
            Console.WriteLine("Todos os métodos da classe string:");

            foreach (var method in typeof(string).GetMethods())
                Console.WriteLine(method.Name);

        }
    }
}
