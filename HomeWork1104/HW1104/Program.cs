using System;

namespace HW1104
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new Cars<Car>();

            cars[0] = new Car("BMW", "M3", 3, "AI98");
            cars[1] = new Car("TOYOTA", "Camry", 3.5, "AI95");
            cars[2] = new Car("AUDI", "RS7", 4, "AI98");

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.ToString()}");
            }

        }
    }
}
