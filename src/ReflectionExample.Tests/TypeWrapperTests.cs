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
        public void CanListAllProperties()
        {
            var type = new TypeWrapper(typeof(SimpleValues));

            type.Properties.Select(x => x.Name)
                .Should().Have.SameValuesAs("FirstValue", "SecondValue");
        }

        [Test]
        public void CreateInstanceCreatesANewInstance()
        {
            var type = new TypeWrapper(typeof(SimpleValues));

            var obj1 = type.CreateInstance();
            var obj2 = type.CreateInstance();

            obj1.Should().Be.OfType<SimpleValues>();
            obj2.Should().Be.OfType<SimpleValues>();
            obj1.Should().Not.Be(obj2);

        }
    }
}
