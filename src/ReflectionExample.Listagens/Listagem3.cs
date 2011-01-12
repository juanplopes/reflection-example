using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;

namespace ReflectionExample.Listagens
{
    public class Listagem3
    {
        public static void Test()
        {
var type = typeof(Foo);
var method = type.GetMethod("Bar");
var foo = new Foo();

var resultado = method.Invoke(foo, new object[] { 3 });

Console.WriteLine(resultado);

        }
    }
}
