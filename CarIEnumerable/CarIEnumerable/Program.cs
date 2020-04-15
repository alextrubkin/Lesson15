using System;
using System.Collections;
using System.Collections.Generic;

namespace CarIEnumerable
{
    class Program
    {
        public static void PrintMessage<T>(string nameMyCollection, TCastomCollection<T>collectionT)
        {
            Console.WriteLine($"\nMethod \"GetTypeOfGeneric()\" from TCastomCollection class:" +
                $"\n{nameMyCollection} has type {collectionT.GetTypeOfGeneric()}");
        }
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
            Console.WriteLine("-___________________________________________________-") ;

            var myCarCollection = new TCastomCollection<Car>();
            myCarCollection.Add(car1);
            myCarCollection.Add( car2);
            foreach(var car in myCarCollection)
                Console.WriteLine(car);
            
           // Console.WriteLine($"{nameof(myCarCollection)} has type { myCarCollection.GetTypeOfGeneric()}");
           
            PrintMessage($"{nameof(myCarCollection)}", myCarCollection);
            Console.WriteLine("-___________________________________________________-");

            var bike1 = new Bike("Winner", 2018, EnumColor.Red);
            var bike2 = new Bike("Azimut", 2017, EnumColor.Green);
            var myBikeCollection = new TCastomCollection<Bike>();
            myBikeCollection.AddRange(new List<Bike> { bike1, bike2 });
            foreach (var bike in myBikeCollection)
            {
                Console.WriteLine(bike);
            }
            PrintMessage($"{nameof(myBikeCollection)}", myBikeCollection);

            Console.WriteLine("-___________________________________________________-");

            var numbers = new NumberUserCollection(6);

            Console.WriteLine(numbers.GetMyStrings());
            var myNumberCollection = new TCastomCollection<int>();
            myNumberCollection.AddRange(numbers);
            foreach(var numb in myNumberCollection)
            {
                Console.Write(numb+" ");
            }
            PrintMessage($"{nameof(myNumberCollection)}", myNumberCollection);
            Console.WriteLine("-___________________________________________________-");

            var myMovingCollection = new TCastomCollection<IMoving>();
            myMovingCollection.AddRange(new List<IMoving> { car1, car2, bike1, bike2 });
            foreach( var transport in myMovingCollection)
            {
                Console.WriteLine( transport );
            }
            PrintMessage($"{nameof(myMovingCollection)}", myMovingCollection);
            Console.WriteLine("-___________________________________________________-");

            var myHeapCollection = new TCastomCollection<IHeap>();
            myHeapCollection.Add(car3);
            myHeapCollection.Add(bike2);
            myHeapCollection.Add(numbers);
            for(int i=0; i<myHeapCollection.Count;i++)
            {
                Console.WriteLine(myHeapCollection[i].GetMyStrings());
            }
            PrintMessage($"{nameof(myHeapCollection)}", myHeapCollection);
            Console.WriteLine("-___________________________________________________-");

            var childBike1 = new ChildBike("First", 2020, EnumColor.Red, 3);
            IHeap heapChildBike1 = childBike1 as IHeap;
            // ___________________________________________________________________________
            var bike4 = new Bike("Ledy", 2017, EnumColor.White);
            IPresent<Bike> newPresent = new PresentBox<Bike>(bike4);
            Console.WriteLine($"I'm new present-{newPresent}-impl IPresent");
            //IPresent<Bike> newPresent1 = new PresentBox<Bike>(bike2);
            //Console.WriteLine($"I {newPresent1} became a present");
            
            IPresent<Bike> newPresent2 = new PresentBox<Bike>(childBike1);
            newPresent2.Print();//child
            childBike1.ChildPrint();

            //IPresent<ChildBike> newPresent3 = new PresentBox<Bike>(bike4);
            //newPresent3.Print();//bike
            //newPresent3.
            IPresent<Bike> newPresent4 = new PresentBox<ChildBike>(childBike1);
            newPresent4.Print();//child
        }
    }
}
