using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Car : B
    {
        private string typeOfBody;
        private int mileage;
        public string TypeOfBody
        {
            get { return typeOfBody; }
            set { typeOfBody = value; }
        }
        public int Mileage
        {
            get { return mileage; }
            set { mileage = value; }
        }
        public Car(string typeOfBody, int mileage, string brand, int year, int weight) : base(brand, year, weight)
        {
            this.typeOfBody = typeOfBody;
            this.mileage = mileage;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"The brand: {Brand}");
            Console.WriteLine($"The weight: {Weight}");
            Console.WriteLine($"The year: {Year}");
            Console.WriteLine($"The type of body: {typeOfBody}");
            Console.WriteLine($"The mileage: {mileage}");
        }
        public override void Work()
        {
            Console.WriteLine("I drive on the road");
        }
    }
}
