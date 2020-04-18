using System;

namespace HomeWork15
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var carsCollection1 = new Cars<Vehicle>();

            carsCollection1[0] = new Car<int>("Volvo", "3108AX", Color.green, 42);
            carsCollection1[1] = new Car<string>("Renaut", "4532HA", Color.yellow, "50");
            carsCollection1[2] = new Car<int>("Dodge", "9976KA", Color.white, 55);
            carsCollection1[3] = new Car<string>("Honda", "5427AH", Color.yellow, "40");
            carsCollection1[4] = new Car<int>("Mercedes", "7744HP", Color.yellow, 38);

            foreach (var item in carsCollection1)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("====================================================================================================");

            var vansCollection2 = new Cars<Vehicle>();

            vansCollection2[0] = new Van<string>("Volvo", "3108AС", Color.green, "45");
            vansCollection2[1] = new Minivan<int>("Renaut", "4534HA", Color.red, 40);
            vansCollection2[2] = new Pickup<string>("Dodge", "3336KA", Color.white, "52");
            vansCollection2[3] = new Van<int>("Honda", "1237AH", Color.black, 44);
            vansCollection2[4] = new Van<string>("Mercedes", "9874HP", Color.yellow, "42");


            foreach (var item in vansCollection2.YieldImplementation())
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadKey();
        }
    }
}
