using System;
namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Car car = new Car("crossover", 150000, "bmw", 2015, 1);
            Plane plane = new Plane("subsonic", 3, "ah-132", 2010, 300);
            Train train = new Train("night express", 16, "speed train", 2009, 400);
            A a = new A(car, plane, train);
            a.GetInheritanceHierarchy(a.GetType());

        }
    }
}