using System;

namespace Cars
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var carsCollection = new Cars(
                new[]{
                    new Car("Red", 4),
                    new Car("Blue", 6),
                    new Car("Green", 8),
                    new Car("White", 6),
                });

            Console.WriteLine(new string('-', 45));

            foreach (Car car in carsCollection)
            {
                Console.WriteLine(car.ToString());
            }

            Console.WriteLine(new string('-', 45));

            foreach (Car car in carsCollection)
            {
                Console.WriteLine(car.ToString());
            }

            Console.WriteLine(new string('-', 45));

            Console.ReadKey();
        }
    }
}
