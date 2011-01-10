using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReflectionExample.Tests.Samples
{
    public class DateValues
    {
        [DateField(1, 8, "yyyyMMdd")]
        public DateTime FirstValue { get; set; }

        [DateField(9, 18, "dd/MM/yy")]
        public DateTime SecondValue { get; set; }
    }
}
