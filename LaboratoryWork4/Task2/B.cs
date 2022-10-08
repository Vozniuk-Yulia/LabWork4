using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal abstract class B
    {
        private string brand;
        private int year;
        private int weight;
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public B(string brand, int year, int weight)
        {
            this.brand = brand;
            this.year = year;
            this.weight = weight;
        }
        public abstract void ShowInfo();
        public abstract void Work();
    }
}
