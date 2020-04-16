using System;
using HomeWork_15.StorageVehicle;
namespace HomeWork_15
{
    public class Program
    {
        static void Main(string[] args)
        {

            var listOfCars = new CarsInfo<Car<int>>();
            listOfCars[0] = new Van<int>("BMW", "AX1111BH", Color.black, 850);
            listOfCars[1] = new Minivan<int>("Citroen", "AX1341AB", Color.blue, 470);
            listOfCars[2] = new Sedan<int>("Lexus", "BH3411AH", Color.greeen, 220);
            listOfCars[3] = new Truck<int>("Mitsubishi", "AA1568EM", Color.red, 1150);
            listOfCars[4] = new Tank<int>("Abrams", "HGBJD44", Color.greeen, 400000);
            listOfCars[5] = new Bycycle<int>("Start", "nonID", Color.red, 500);

            foreach (var item in listOfCars)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("| ----------------------------------------------------------|");
            foreach (var item in listOfCars.RealizationYield())
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("| ----------------------------------------------------------|");
            Console.ReadKey();
        }
    }
}
