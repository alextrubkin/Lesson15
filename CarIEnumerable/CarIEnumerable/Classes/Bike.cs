using System;

namespace CarIEnumerable
{
     public class Bike:IMoving,IHeap
    {        
        public string Name { get; set; }
        public int Year { get; set; }
        public EnumColor Color { get; set; }        

        public Bike(string name, int year, EnumColor color)
        {
            Name = name;
            Year = year;
            Color = color;
        }

        public override string ToString()
        {
            return $"{Name}| {Color}| {Year}|";
        }

        public void ToMove()
        {
            Console.WriteLine("I'm a bike & I'm moving");
        }

        public string GetMyStrings()
        {
            return Name.ToString();
        }
    }
}
