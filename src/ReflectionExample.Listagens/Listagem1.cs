using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;
using System.ComponentModel;

namespace ReflectionExample.Listagens
{
    public class Foo
    {
        public int FieldA;

        [Description("propriedade A")]
        public int PropertyA { get; set; }

        public string Bar(int parameter)
        {
            return "abc";
        }
    }
}
