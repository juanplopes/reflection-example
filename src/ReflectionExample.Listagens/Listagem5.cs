using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;
using System.Linq.Expressions;

namespace ReflectionExample.Listagens
{
    public class Listagem5
    {
        public static void Test()
        {
            var propA = typeof(Foo).GetProperty("PropertyA");

            var foo = Expression.Parameter(typeof(Foo));
            var value = Expression.Parameter(typeof(int));

            var assign = Expression.Assign(Expression.Property(foo, propA), value);
            var lambda = Expression.Lambda<Action<Foo, int>>(assign, foo, value).Compile();

            var instance = new Foo();

            lambda(instance, 42);
            Console.WriteLine(instance.PropertyA);
        }
    }
}
