using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ReflectionExample.Tests.Samples;
using SharpTestsEx;

namespace ReflectionExample.Tests
{
    [TestFixture]
    public class TypeWrapperTests
    {
        [Test]
        public void CanWriteSimpleValues()
        {
            var prop = new TypeWrapper(typeof(SimpleValues));

            prop.WriteFrom(new SimpleValues() { FirstValue = 50, SecondValue = "42" })
                .Should().Be("50   42   ");
        }

        [Test]
        public void CanReadSimpleValues()
        {
            var prop = new TypeWrapper(typeof(SimpleValues));

            var obj = prop.ReadFrom("50   42   ").Should().Be.OfType<SimpleValues>().And.ValueOf;
            obj.FirstValue.Should().Be(50);
            obj.SecondValue.Should().Be("42");
        }
       
    }
}
