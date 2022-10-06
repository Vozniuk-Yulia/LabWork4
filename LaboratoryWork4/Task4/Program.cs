using System;
namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first access key number:");
            string accessKey1=Console.ReadLine();
            Console.WriteLine("Enter the second access key number:");
            string accessKey2 = Console.ReadLine();
            Input input = new Input(accessKey1, accessKey2);
            input.DefineAccess();
        }
    }
}