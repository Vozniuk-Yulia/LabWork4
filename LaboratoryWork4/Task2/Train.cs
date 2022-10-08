using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Train : B
    {
        private string type;
        private int countOfWagons;
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public int Mileage
        {
            get { return countOfWagons; }
            set { countOfWagons = value; }
        }
        public Train(string type, int countOfWagons, string brand, int year, int weight) : base(brand, year, weight)
        {
            this.type = type;
            this.countOfWagons = countOfWagons;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"The brand: {Brand}");
            Console.WriteLine($"The weight: {Weight}");
            Console.WriteLine($"The year: {Year}");
            Console.WriteLine($"The type: {type}");
            Console.WriteLine($"The count of wagons: {countOfWagons}");
        }
        public override void Work()
        {
            Console.WriteLine("I ride on the tracks");
        }
    }
}
