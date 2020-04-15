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

            IContainer<Bus> container = new Container<Car>(bus);
            IContainer<Minivan> container1 = new Container<Car>(minivan);
            IContainer<Van> container2 = new Container<Car>(van);

            Console.WriteLine(container.ToString());
            Console.WriteLine(container1.ToString());
            Console.WriteLine(container2.ToString());


            Console.ReadLine();
        }
    }
}