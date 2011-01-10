using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using SharpTestsEx;
using System.Globalization;
using ReflectionExample.Tests.Samples;

namespace ReflectionExample.Tests
{
    [TestFixture]
    public class PropertyWrapperTests
    {
        [Test]
        public void CanWriteSingleInt()
        {
            var prop = new PropertyWrapper(typeof(SimpleValues).GetProperty("FirstValue"));

            prop.IsValid.Should().Be.True();

            var builder = new StringBuilder();
            prop.WriteTo(builder, new SimpleValues() { FirstValue = 50 });
            builder.ToString().Should().Be("50   ");
        }

        [Test]
        public void CanWriteSingleIntInSpaceString()
        {
            var prop = new PropertyWrapper(typeof(SimpleValues).GetProperty("FirstValue"));

            prop.IsValid.Should().Be.True();

            var builder = new StringBuilder(new string(' ', 10));
            prop.WriteTo(builder, new SimpleValues() { FirstValue = 42 });
            builder.ToString().Should().Be("42        ");
        }

        [Test]
        public void CanReadSingleInt()
        {
            var prop = new PropertyWrapper(typeof(SimpleValues).GetProperty("FirstValue"));

            prop.IsValid.Should().Be.True();

            var sample = new SimpleValues();
            prop.ReadFrom("50\0\0\0\0\0\0\0\0", sample);

            sample.FirstValue.Should().Be(50);
        }

        [Test]
        public void CanReadSingleIntInALessThan5CharsString()
        {
            var prop = new PropertyWrapper(typeof(SimpleValues).GetProperty("FirstValue"));

            prop.IsValid.Should().Be.True();

            var sample = new SimpleValues();
            prop.ReadFrom("50", sample);

            sample.FirstValue.Should().Be(50);
        }

        [Test]
        public void CanReadSingleIntInSpaceString()
        {
            var prop = new PropertyWrapper(typeof(SimpleValues).GetProperty("FirstValue"));

            prop.IsValid.Should().Be.True();

            var sample = new SimpleValues();
            prop.ReadFrom("50                   ", sample);

            sample.FirstValue.Should().Be(50);
        }
    }
}
