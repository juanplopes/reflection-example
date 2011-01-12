using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;
using System.ComponentModel;

namespace ReflectionExample.Listagens
{
    public class Listagem2
    {
        public static void Test()
        {
            var propA = typeof(Foo).GetProperty("PropertyA");
            var attribute = propA
                .GetCustomAttributes(typeof(DescriptionAttribute), true)
                .OfType<DescriptionAttribute>().First();
            Console.WriteLine(attribute.Description);
        }
    }
}
