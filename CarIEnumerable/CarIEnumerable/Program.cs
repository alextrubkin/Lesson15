using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarIEnumerable
{
    class Program
    {
        //Сделать класс автомобиль ( Car), параметры опциональны. Сделать класс Cars, реализующий IEnumerable.
       // Заполнить коллекцию, делать вызовы как через foreach, так и при помощи yield
        static void Main(string[] args)
        {
            var car1 = new Car(12312, "Lada", EnumsCarBody.Sedan);
            var car2 = new Car(45678, "Daewoo", EnumsCarBody.Hatchback);
            var car3 = new Car(78912, "Ford", EnumsCarBody.Wagon);
            var car4 = new Car(14725, "BMW", EnumsCarBody.Jeep);
            var car5 = new Car(14726, "BMW1", EnumsCarBody.Jeep);

            var carArray = new CarCollection();
           
            carArray[0] = car1;
            carArray[1] = car2;
            carArray[2] = car3;
            carArray[3] = car4;

            foreach (var car in carArray)
            {
                Console.WriteLine(car);
            }
            Console.WriteLine();
            IEnumerator ie = (carArray as IEnumerable).GetEnumerator();
            
            while (ie.MoveNext())
            {
               Car car = ie.Current as Car;

                Console.WriteLine(car);
            }

            var numbersUserCollection = new NumberUserCollection(5);

            foreach (var place in numbersUserCollection)
            {
                Console.WriteLine(place);
            }

            var carsUserCollection = new CarsOwnCollection();
            carsUserCollection.AddItem(car1);
            carsUserCollection.AddItem(car2);
            carsUserCollection.AddItem(car3);
            carsUserCollection.AddItem(car4);
            carsUserCollection.AddItem(car5);
            Console.WriteLine("\nMarks for my collection:");

            foreach(var car in carsUserCollection.GetNamesForMyCollection("B"))
            {
                Console.WriteLine(car);
            }





        }
    }
}
