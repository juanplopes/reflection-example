using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.IO;
using ReflectionExample.Tests.Samples;
using SharpTestsEx;

namespace ReflectionExample.Tests
{
    [TestFixture]
    public class FixedColumnsSerializerTests
    {
        [Test]
        public void CanWriteOneSimpleValueIntoStream()
        {
            var str = new StringWriter();
            str.NewLine = "\n";
            var serializer = new FixedColumnsSerializer(typeof(SimpleValues));

            serializer.Write(str, new SimpleValues() { FirstValue = 1, SecondValue = "2" });

            str.ToString().Should().Be("1    2    \n");
        }

        [Test]
        public void CanWriteTwoSimpleValueIntoStream()
        {
            var str = new StringWriter();
            str.NewLine = "\n";
            var serializer = new FixedColumnsSerializer(typeof(SimpleValues));

            serializer.Write(str, new SimpleValues() { FirstValue = 1, SecondValue = "2" });
            serializer.Write(str, new SimpleValues() { FirstValue = 3, SecondValue = "444444" });

            str.ToString().Should().Be("1    2    \n3    44444\n");
        }

        [Test]
        public void CanWriteAllSimpleValueIntoStream()
        {
            var str = new StringWriter();
            str.NewLine = "\n";
            var serializer = new FixedColumnsSerializer(typeof(SimpleValues));

            serializer.WriteAll(str, new[] {
                new SimpleValues() { FirstValue = 1, SecondValue = "2" } ,
                new SimpleValues() { FirstValue = 3, SecondValue = "444444" }
            });

            str.ToString().Should().Be("1    2    \n3    44444\n");
        }

        [Test]
        public void CanReadNullValueFromEmptyStream()
        {
            var str = new StringReader("");
            var serializer = new FixedColumnsSerializer(typeof(SimpleValues));

            serializer.Read(str).Should().Be.Null();
        }

        [Test]
        public void CanReadOneSimpleValueFromStream()
        {
            var str = new StringReader("1    2    \n");
            var serializer = new FixedColumnsSerializer(typeof(SimpleValues));

            var obj1 = serializer.Read(str).Should().Be.OfType<SimpleValues>();
            obj1.And.ValueOf.FirstValue.Should().Be(1);
            obj1.And.ValueOf.SecondValue.Should().Be("2");

            serializer.Read(str).Should().Be.Null();
        }

        [Test]
        public void CanReadOneSimpleValueWithoutNewLineFromStream()
        {
            var str = new StringReader("1    2");
            var serializer = new FixedColumnsSerializer(typeof(SimpleValues));

            var obj1 = serializer.Read(str).Should().Be.OfType<SimpleValues>();
            obj1.And.ValueOf.FirstValue.Should().Be(1);
            obj1.And.ValueOf.SecondValue.Should().Be("2");

            serializer.Read(str).Should().Be.Null();
        }

        [Test]
        public void CanReadTwoSimpleValueFromStream()
        {
            var str = new StringReader("1    2    \n3    44444\n");
            var serializer = new FixedColumnsSerializer(typeof(SimpleValues));

            var obj1 = serializer.Read(str).Should().Be.OfType<SimpleValues>();
            obj1.And.ValueOf.FirstValue.Should().Be(1);
            obj1.And.ValueOf.SecondValue.Should().Be("2");

            var obj2 = serializer.Read(str).Should().Be.OfType<SimpleValues>();
            obj2.And.ValueOf.FirstValue.Should().Be(3);
            obj2.And.ValueOf.SecondValue.Should().Be("44444");

            serializer.Read(str).Should().Be.Null();
        }

        [Test]
        public void CanReadAllSimpleValueFromStream()
        {
            var str = new StringReader("1    2    \n3    44444\n");
            var serializer = new FixedColumnsSerializer(typeof(SimpleValues));

            var list = serializer.ReadAll(str).OfType<SimpleValues>().ToArray();
            list.Should().Have.Count.EqualTo(2);

            list[0].FirstValue.Should().Be(1);
            list[0].SecondValue.Should().Be("2");

            list[1].FirstValue.Should().Be(3);
            list[1].SecondValue.Should().Be("44444");
        }
    }
}
