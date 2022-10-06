using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Device:Goods
    {
        private int memorySize;
        private int screenDiagonal;
        public Device(string name, int code, string description, int price, int memorySize, int screenDiagonal) : base(name, code, description, price)
        {
            this.memorySize = memorySize;
            this.screenDiagonal = screenDiagonal;
        }
        public override void ShowInfo()
        {
            Console.WriteLine("Device");
            Console.WriteLine($"Name of the product: {Name}");
            Console.WriteLine($"Code: {Code}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Memory size: {memorySize}");
            Console.WriteLine($"Screen diagonal: {screenDiagonal}");
        }
    }
}
