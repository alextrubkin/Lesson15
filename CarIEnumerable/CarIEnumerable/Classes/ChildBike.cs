using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarIEnumerable
{
     public class ChildBike:Bike
    {
        public int CountWheels { get; set; }
        public ChildBike(string name, int year, EnumColor color,int countWheels)
            :base(name,year,color)
        {
            CountWheels = countWheels;
        }

        public void ChildPrint()
        {
            Console.WriteLine($"I'm for children: "+base.ToString());
        }
    }
}
