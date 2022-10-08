using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Plane : B
    {
        private string typeOfFlightSpeed;
        private int countOfEngine;
        public string TypeOfFlightSpeed
        {
            get { return typeOfFlightSpeed; }
            set { typeOfFlightSpeed = value; }
        }
        public int CountOfEngine
        {
            get { return countOfEngine; }
            set { countOfEngine = value; }
        }
        public Plane(string typeOfFlightSpeed, int countOfEngine, string brand, int year, int weight) : base(brand, year, weight)
        {
            this.typeOfFlightSpeed = typeOfFlightSpeed;
            this.countOfEngine = countOfEngine;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"The brand: {Brand}");
            Console.WriteLine($"The weight: {Weight}");
            Console.WriteLine($"The year: {Year}");
            Console.WriteLine($"The type of flight speed: {typeOfFlightSpeed}");
            Console.WriteLine($"The count of engine: {countOfEngine}");
        }
        public override void Work()
        {
            Console.WriteLine("I fly in sky");
        }
    }
}
