using System;
namespace HomeWork_15
{
    public class Program
    {
        static void Main(string[] args)
        {
            var listOfCars = new CarsInfo();
            listOfCars.AddCar(new Car("BMW", "AX1111BH", Color.black, 850));
            listOfCars.AddCar(new Car("Citroen", "AX1341AB", Color.blue, 470));
            listOfCars.AddCar(new Car("Lexus", "BH3411AH", Color.greeen, 220));
            listOfCars.AddCar(new Car("Mitsubishi", "AA1568EM", Color.red, 1150));
            listOfCars.AddCar(new Car("Opel", "AX9436CT", Color.white, 400));
            listOfCars.AddCar(new Car("Mazda", "AX1870BT", Color.yellow, 750));
            listOfCars.AddCar(new Car("Jaguar", "AX2345BM", Color.black, 2350));

            foreach (Car cars in listOfCars)
            {
                Console.WriteLine(cars.ToString());
            }
            Console.WriteLine("| ----------------------------------------------------------|");
            foreach (var item in listOfCars.GetCarCheaper1000())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("| ----------------------------------------------------------|");           
        }
    }
}
