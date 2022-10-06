using System;
namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Output<string> message = new Output<string>();
            message.Show("one", "two");
            Display<double> display = new Display<double>();
            display.Show(20.50, 32.15);
        }
    }
}