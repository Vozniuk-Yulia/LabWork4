using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Product:Goods
    {
        private double calories;
        private DateOnly expirationDate;
        private string subCategory;
        public double Calories
        {
            get { return calories; }
            set { calories = value; }
        }
        public Product(string name, int code, string description, int price,double calories,DateOnly expirationDate,string subCategory):base(name,code,description,price)
        {
            this.calories = calories;
            this.expirationDate = expirationDate;
            this.subCategory = subCategory;

        }
        public override void ShowInfo()
        {
            Console.WriteLine("Product");
            Console.WriteLine($"Name of the product: {Name}");
            Console.WriteLine($"Code: {Code}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Calories: {calories}");
            Console.WriteLine($"Expiration date: {expirationDate}");
            Console.WriteLine($"Subcategory: {subCategory}");
        }
    }
}
