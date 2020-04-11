using System.Collections.Generic;
using System.Collections;

namespace HomeWork15
{
    public class Cars : IEnumerable
    {
        List<Car> cars { get; set; }

        public Cars()
        {
            cars = new List<Car>();
        }

        public Car this[int index]
        {
            get
            {
                return cars[index];
            }
            set
            {
                cars[index] = value;
            }
        }

        public void AddNewCar(Car car)
        {
            cars.Add(car);
        }
        public IEnumerator GetEnumerator()
        {
            return cars.GetEnumerator();
        }

        public IEnumerable GetYellowCars()
        {
            for (int i = 0; i < cars.Count - 1; i++)
            {
                if (cars[i].Color== Color.yellow)
                {
                    yield return cars[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < cars.Count; i++)
            {
                yield return cars[i];
                yield return cars[i];
            }
        }
    }
}

