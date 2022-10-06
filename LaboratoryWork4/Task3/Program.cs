using System;
namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clothes clothes = new Clothes("Crop-top", 1245, "very beautiful", 349, "caton", "blouse", 42);
            Device device = new Device("Iphone 14", 789, "cool device", 41499, 128, 6);
            Product product = new Product("La Cabane", 23, "delicious", 59, 360, new DateOnly(2022, 11, 10), "dairy");
            List<Goods> goods = new List<Goods>();
            goods.Add(product);
            goods.Add(clothes);
            goods.Add(device);
            foreach (Goods good in goods)
            {
                good.ShowInfo();
                Console.WriteLine();
            }
            typeof(Clothes)
               .GetProperties()
               .Select(x => x.GetValue(clothes, null))
               .ToList()
               .ForEach(x => Console.WriteLine(x));
        }
    }
}