using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;

namespace ReflectionExample.Listagens
{
    public class Listagem0C
    {
        public static void Test()
        {
var type = typeof(string);
var method = type.GetMethod("Substring", new[] { typeof(int) });

var str = "abcdefghij";
var resultado = (string)method.Invoke(str, new object[] { 3 });

Console.WriteLine(resultado);


        }
    }
}
