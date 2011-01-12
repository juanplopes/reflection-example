using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;
using System.Diagnostics;
using System.Linq.Expressions;

namespace ReflectionExample.Listagens
{
    public class Listagem5
    {
        public static void Test()
        {
            var foo = new Foo();
            var bar = typeof(Foo).GetMethod("Bar");

            var param = Expression.Parameter(typeof(int));
            var call = Expression.Call(Expression.Constant(foo), bar, param);
            var lambda = Expression.Lambda<Func<int, string>>(call, param).Compile();

            var s = Stopwatch.StartNew();
            for (int i = 0; i < 5000000; i++)
                foo.Bar(i);

            Console.WriteLine("Sem reflection: {0}", s.Elapsed);

            s.Restart();
            for (int i = 0; i < 5000000; i++)
                lambda.Invoke(i);

            Console.WriteLine("Com reflection: {0}", s.Elapsed);
        }
    }
}
