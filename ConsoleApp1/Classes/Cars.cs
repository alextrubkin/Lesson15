using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    public class Cars  : IEnumerable
    {
        readonly Car [] cars = new Car [5];

        public Car this[int index]
        {
            get { return cars[index]; }
            set { cars[index] = value; }
        }

        private int position = -1;

        public void Reset()
        {
            position = -1;
        }

        public IEnumerator GetEnumerator()
        {
            while (true)
            {
                if (position < cars.Length - 1)
                {
                    position++;
                    yield return cars[position];
                }
                else
                {
                    Reset();
                    yield break;       
                }
            }
        }

        public IEnumerable <string> GetCars ()
        {
            foreach (Car car in cars)
            {
                yield return car.PrintCar();
            }
        }

       

       
    }
}
