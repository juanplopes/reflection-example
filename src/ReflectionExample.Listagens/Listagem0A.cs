using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReflectionExample.Listagens
{
    public class Listagem0A
    {
        public static void Test()
        {
            var foo = new Foo();

            var type1 = foo.GetType();
            var type2 = typeof(Foo);
        }
    }
}
