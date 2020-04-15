using System;
using CollectionsTask_Console.Collection;

namespace CollectionsTask_Console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var cars = new Cars<Car>();

            cars[0] = new Car("Mazda", "Red", 150);
            cars[1] = new Van("Honda", "Blue", 130);
            cars[2] = new Car("Mitsubishi", "Grey", 170);
            cars[3] = new Car("Zhiguli", "Yellow", 100);

            foreach(Car car in cars)
            {
                Console.WriteLine(car);
            }

            Console.WriteLine("-------------------------------------");

            foreach(Car car in cars)
            {
                Console.WriteLine(car);
            }

            Console.ReadKey();
        }
    }
}
