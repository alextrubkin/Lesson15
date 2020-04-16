using System;

namespace Homework15
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Car bus = new Bus("yellow", 26, "Mazda");
            Car minivan = new Minivan("white", 23, "BMW");
            Car van = new Van("black", 18, "BMW");

            IContainer<Car> container = new Cars<Car>(bus);
            IContainer<Car> container1 = new Cars<Car>(minivan);
            IContainer<Car> container2 = new Cars<Car>(van);

            Console.WriteLine(container.ToString());
            Console.WriteLine(container1.ToString());
            Console.WriteLine(container2.ToString());


            Console.ReadLine();
        }
    }
}