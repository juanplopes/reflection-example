using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReflectionExample.Tests.Samples
{
    public class SimpleValues
    {
        [Field(1, 5)]
        public int FirstValue { get; set; }

        [Field(6, 10)]
        public string SecondValue { get; set; }

        public DateTime NotIncluded { get; set; }
    }
}
