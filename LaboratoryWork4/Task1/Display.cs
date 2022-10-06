using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Display<T>:Output<T>
    {
        public override void Show(T value1, T value2)
        {
            Console.WriteLine("First value and type:");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(value1);
            Console.WriteLine(value1.GetType());
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Second value and type:");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(value2);
            Console.WriteLine(value2.GetType());
        }
    }
}
