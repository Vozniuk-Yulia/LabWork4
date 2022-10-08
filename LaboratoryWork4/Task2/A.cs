using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class A
    {
        public A(B value1)
        {
            Console.WriteLine($"In garage is one transport: {value1}");
        }
        public A(B value1, B value2)
        {
            Console.WriteLine($"In garage are two transport: {value1}, {value2}");
        }
        public A(B value1, B value2, B value3)
        {
            Console.WriteLine($"In garage are three transport: {value1}, {value2}, {value3}");
        }
        public IEnumerable<Type> GetInheritanceHierarchy(Type type)
        {
            for (var current = type; current != null; current = current.BaseType)
            {
                yield return current;
            }
        }
    }
}
