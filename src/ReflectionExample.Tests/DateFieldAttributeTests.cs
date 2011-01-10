using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using SharpTestsEx;
using System.Globalization;

namespace ReflectionExample.Tests
{
    [TestFixture]
    public class DateFieldAttributeTests
    {
        [Test]
        public void CanWriteSingleDateWithNoFormat()
        {
            var attr = new DateFieldAttribute(2, 11);
            var builder = new StringBuilder();
            attr.WriteTo(builder, new DateTime(2011, 01, 10));
            builder.ToString().Should().Be("\001/10/2011");
        }

        [Test]
        public void CanWriteSingleDateWithDDMMYYYYformat()
        {
            var attr = new DateFieldAttribute(2, 11,"ddMMyyyy");
            var builder = new StringBuilder();
            attr.WriteTo(builder, new DateTime(2011, 01, 10));
            builder.ToString().Should().Be("\010012011  ");
        }

        [Test]
        public void CanReadSingleDateWithNoFormat()
        {
            var attr = new DateFieldAttribute(2, 11);

            attr.ReadFrom("\001/10/2011", typeof(DateTime))
                .Should().Be(new DateTime(2011, 01, 10));
        }

        [Test]
        public void CanReadSingleDateWithDDMMYYYYformat()
        {
            var attr = new DateFieldAttribute(2, 11, "ddMMyyyy");
            attr.ReadFrom("\010012011  ", typeof(DateTime))
                .Should().Be(new DateTime(2011, 01, 10));
        }

    }
}
