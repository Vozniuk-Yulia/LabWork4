using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Clothes:Goods
    {
        private string material;
        private string type;
        private int size;
        public string Material
        {
            get { return material; }
            set { material = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public int Size
        {
            get { return size; }
            set { size = value; }
        }
        public Clothes(string name, int code, string description, int price, string material, string type, int size) : base(name, code, description, price)
        {
            this.material = material;
            this.type = type;
            this.size = size;
        }
        public override void ShowInfo()
        {
            Console.WriteLine("Clothes");
            Console.WriteLine($"Name of the product: {Name}");
            Console.WriteLine($"Code: {Code}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Material: {material}");
            Console.WriteLine($"Type: {type}");
            Console.WriteLine($"Size: {size}");
        }

    }
}
