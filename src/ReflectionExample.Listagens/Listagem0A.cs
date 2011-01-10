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
            var abc = "abc";

            var stringType1 = abc.GetType(); //string
            var stringType2 = typeof(string); //string
        }
    }
}
