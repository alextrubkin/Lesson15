using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework15
{
    public class Car
    {
        public string Name { get; private set; }
        public int ID { get; private set; }
        public decimal Price { get; private set; }


        public Car(string name, int number, decimal price)
        {
            Name = name;
            ID = number;
            Price = price;
        }


        public override string ToString()
        {
            return $"Name: {Name}, ID: {ID:d3}, price: {Price} $.";
        }
    }
}
