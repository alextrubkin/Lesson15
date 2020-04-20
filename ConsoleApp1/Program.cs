using ConsoleApp1.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class Program
    {
        public static void Main(string[] args)
        {
            var cars = new Cars();
            cars[0] = new Car("Mercedes", "Black", "AZ123", 1000000);
            cars[1] = new Car("BMW", "White", "AX143", 800000);
            cars[2] = new Car("Volvo", "Green", "AG423", 700000);
            cars[3] = new Car("Ford", "Blue", "AF167", 99000);
            cars[4] = new Car("Honda", "Red", "AC456", 500000);


            foreach (Car car in cars)
            {
                Console.WriteLine(car.PrintCar());
            }


            Console.WriteLine("-------------------------------------");


            IEnumerator enumCar = (cars as IEnumerable).GetEnumerator();

            while (enumCar.MoveNext())
            {
                Car car = enumCar.Current as Car;

                Console.WriteLine(car.PrintCar());
            }


            Console.WriteLine("-------------------------------------");


            foreach (IEnumerable car in cars.GetCars())
            {
                Console.WriteLine(car);
            }



            Console.ReadKey();
        }

    }
}
