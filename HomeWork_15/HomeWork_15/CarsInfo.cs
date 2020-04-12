
using System.Collections;
using System.Collections.Generic;

namespace HomeWork_15
{
    public class CarsInfo : IEnumerable
    {
        List<Car> cars { get; set; }
        public CarsInfo()
        {
            cars = new List<Car>();
        }      

        public Car this[int index]
        {
            get { return cars[index]; }
            set { cars[index] = value; }
        }
               
        public void AddCar(Car car)
        {
            cars.Add(car);
        }
       
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)this;
        }
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < cars.Count; i++)
            {
                yield return cars[i];
            }
        }
        public IEnumerable GetCarCheaper1000()
        {
            for (int i = 0; i < cars.Count - 1; i++)
            {
                if (cars[i].Price <=1000 )
                {
                    yield return cars[i];
                }
            }
        }
    }
}
