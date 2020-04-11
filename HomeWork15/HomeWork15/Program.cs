using System;
using System.Collections;

namespace HomeWork15
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var carsCollection = new Cars();

            carsCollection.AddNewCar(new Car("Volvo", "3108AX", Color.green));
            carsCollection.AddNewCar(new Car("Renaut", "4532HA", Color.yellow));
            carsCollection.AddNewCar(new Car("Dodge", "9976KA", Color.white));
            carsCollection.AddNewCar(new Car("Honda", "5427AH", Color.yellow));
            carsCollection.AddNewCar(new Car("Mercedes", "7744HP", Color.yellow));
            carsCollection.AddNewCar(new Car("Volvo", "3108AС", Color.green));
            carsCollection.AddNewCar(new Car("Renaut", "4534HA", Color.red));
            carsCollection.AddNewCar(new Car("Dodge", "3336KA", Color.white));
            carsCollection.AddNewCar(new Car("Honda", "1237AH", Color.black));
            carsCollection.AddNewCar(new Car("Mercedes", "9874HP", Color.yellow));


            //Implementation of foreach:

            foreach (Car cars in carsCollection)
            {
                Console.WriteLine(cars.ToString());
            }

            Console.WriteLine("==================================================================");

            //Implementation of "yield" 1:

            IEnumerable enumerableColor = carsCollection as IEnumerable;
            foreach (var item in enumerableColor)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("==================================================================");

            //Implementation of "yield" 2:

            foreach (Car cars in carsCollection.GetYellowCars())
            {
                Console.WriteLine(cars.ToString());
            }

            Console.ReadKey();
        }
    }
}
