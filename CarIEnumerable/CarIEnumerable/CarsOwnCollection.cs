using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarIEnumerable
{
    public class CarsOwnCollection : IEnumerable<Car>
    {
        List<Car> myOwnCollection { get; set; } 
        public CarsOwnCollection()
        {
            myOwnCollection = new List<Car>();
        }
        public IEnumerator<Car> GetEnumerator()
        {
            foreach (var car in myOwnCollection)
                yield return car;
        }

        public IEnumerable GetNamesForMyCollection(string myLetter)
        {
            foreach(var car in myOwnCollection)
            {
                if(car.CarMake.StartsWith(myLetter))
                {
                    yield return car.CarMake;
                }
               
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void AddItem(Car car)
        {
            myOwnCollection.Add(car);
        }
    }
}
