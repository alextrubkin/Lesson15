using System;

namespace Cars
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var carsCollection = new Cars<Car>();

            carsCollection[0] = new Car("Red", 4);
            carsCollection[1] = new Car("Blue", 6);
            carsCollection[2] = new Car("Green", 8);
            carsCollection[3] = new Car("White", 6);

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
