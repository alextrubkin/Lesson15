using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HW1104
{
    public class Cars<T> : IEnumerable
    {
        public Car[] cars = new Car[3];

        public Car this[int index]
        {
            get { return cars[index]; }
            set { cars[index] = value; }
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var car in cars)
            {
                yield return car;
            }
        }
    }
}
