using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework15
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cars cars = new Cars();

            Car car1 = new Car("First", 1, 1000);
            Car car2 = new Car("Second", 2, 2000);
            Car car3 = new Car("Third", 3, 3000);
            Car car4 = new Car("Fourth", 4, 4000);
            Car car5 = new Car("Fifth", 5, 5000);
            Car car6 = new Car("Sixth", 6, 6000);
            Car car9 = new Car("Ninth", 9, 9000);
            Car car12 = new Car("Twelfth", 12, 12000);


            cars.Add(car1, car2, car3, car4, car5, car6, car9, car12);

            Console.WriteLine("Car info using forech:");
            foreach (var item in cars)
            {
                Console.WriteLine(item);
            }

            Console.Write("\nAny key to continue. . .");
            Console.ReadKey();


            Console.Clear();
            Console.WriteLine("Car info using yield (all cars in list):");
            foreach (var item in cars.GetCarsInfo())
            {
                Console.WriteLine(item);
            }

            Console.Write("\nAny key to continue. . .");
            Console.ReadKey();


            Console.Clear();
            int multiply = 3;
            Console.WriteLine($"\nCar info using yield (view the cars which ID is a multiply of {multiply}):");
            foreach (var item in cars.GetCarsInfo(multiply))
            {
                Console.WriteLine(item);
            }

            Console.Write("\nAny key to quit. . .");           


            Console.ReadKey();
        }
    }

}
