﻿namespace Homework15
{
    public class Car
    {
        private double _price = 1;
        public Car(string color, int price, string name)
        {
            Color = color;
            Price = price;
            Name = name;
        }
        public virtual string Color { get; set; }

        public virtual double Price {get; set;}

        public virtual string Name { get; set; }

        public override string ToString()
        {
            return $"Name Car {Name} has price {Price} and color {Color}";
        }
    }
}