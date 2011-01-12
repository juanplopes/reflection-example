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
    public class FieldAttributeTests
    {
        [Test]
        public void CanWriteSingleInt()
        {
            var attr = new FieldAttribute(5, 10);
            var builder = new StringBuilder();
            attr.WriteTo(builder, 50);
            builder.ToString().Should().Be("\0\0\0\050    ");
        }

        [Test]
        public void CanWriteSingleString()
        {
            var attr = new FieldAttribute(5, 10);
            var builder = new StringBuilder();
            attr.WriteTo(builder, "abcdefg");
            builder.ToString().Should().Be("\0\0\0\0abcdef");
        }

        [Test]
        public void CanWriteSingleIntInSpaceString()
        {
            var attr = new FieldAttribute(5, 10);
            var builder = new StringBuilder(new string(' ', 10));
            attr.WriteTo(builder, 42);
            builder.ToString().Should().Be("    42    ");
        }

        [Test]
        public void CanWriteSingleStringInSpaceString()
        {
            var attr = new FieldAttribute(5, 10);
            var builder = new StringBuilder(new string(' ', 10));
            attr.WriteTo(builder, "abcdefg");
            builder.ToString().Should().Be("    abcdef");
        }

        [Test]
        public void CanReadSingleInt()
        {
            var attr = new FieldAttribute(5, 10);
            var str = "\0\0\0\050\0\0\0\0";
            attr.ReadFrom(str, typeof(decimal)).Should().Be(50m);
        }

        [Test]
        public void CanReadSingleString()
        {
            var attr = new FieldAttribute(5, 10);
            var str = "\0\0\0\050\0\0\0\0";
            attr.ReadFrom(str, typeof(string)).Should().Be("50");
        }

       
        [Test]
        public void CanReadSingleIntInALessThan10CharsString()
        {
            var attr = new FieldAttribute(5, 10);
            var str = "\0\0\0\050";
            attr.ReadFrom(str, typeof(decimal)).Should().Be(50m);
        }

        [Test]
        public void CanReadSingleIntInSpaceString()
        {
            var attr = new FieldAttribute(5, 10);
            var str = "    50    ";
            attr.ReadFrom(str, typeof(decimal)).Should().Be(50m);
        }
    }
}
