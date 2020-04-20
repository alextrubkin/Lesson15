using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    public class Car 
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string Number { get; set; }
        public int Price { get; set; }

        public Car (string name, string color, string number, int price)
        {
            Name = name;
            Color = color;
            Number = number;
            Price = price;
        }

        public string PrintCar ()
        {
            return $"Name: {Name}, Color: {Color}, Number: {Number}, Price: {Price}.";
        }

      

    }
}
