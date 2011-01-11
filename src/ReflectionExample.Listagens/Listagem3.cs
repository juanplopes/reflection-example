using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;
using System.Diagnostics;

namespace ReflectionExample.Listagens
{
    public class Listagem3
    {
        public static void Test()
        {
var foo = new Foo();
var bar = typeof(Foo).GetMethod("Bar");

var s = Stopwatch.StartNew();
for (int i = 0; i < 5000000; i++)
    foo.Bar(i);

Console.WriteLine("Sem reflection: {0}", s.Elapsed);

s.Restart();
for (int i = 0; i < 5000000; i++)
    bar.Invoke(foo, new object[] { i });

Console.WriteLine("Com reflection: {0}", s.Elapsed);
        }
    }
}
