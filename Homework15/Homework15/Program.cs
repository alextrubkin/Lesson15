using System;

namespace Homework15
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var cars = new Cars(new[]
            {

                new Car("white", 23, "BMW"),
                new Car("red", 40, "Bentley"),
                new Car("lack", 25, "Ferrari"),
                new Car("yellow", 26, "Mazda"),
                new Car("black", 18, "BMW"),
                new Car("green", 36, "Ford"),
                new Car("white", 28, "Lexus"),
            });

            foreach (var car in cars)
            {
                Console.WriteLine(car.ToString());
            }
            Console.ReadLine();
        }
    }
}