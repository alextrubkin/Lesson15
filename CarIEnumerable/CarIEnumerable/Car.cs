using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarIEnumerable
{
     public class Car
    {
        public int Number { get; set; }
        public string CarMake { get; set; }

        public EnumsCarBody CarBody { get; set; }

        public Car(int number, string carMake, EnumsCarBody carBody)
        {
            Number = number;
            CarMake = carMake;
            CarBody = carBody;
        }

        public override string ToString()
        {
            return $"number: {Number,6}|mark: {CarMake,8}|body: {CarBody,10}|";
        }
    }
}
