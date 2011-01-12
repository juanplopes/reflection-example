using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReflectionExample
{
public interface IField
{
    void WriteTo(StringBuilder line, object value);
    object ReadFrom(string line, Type type);
}
}
