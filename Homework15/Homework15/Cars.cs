using System.Collections;

namespace Homework15
{
    public class Cars : IEnumerable
    {
        readonly Car[] cars;
        public Cars(Car[] newCars)
        {
            cars = newCars;
        }

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
            yield return new string('-', 10);
            for (int i = 0; i < cars.Length; i++)
            {
                yield return cars[i];
            }
        }
    }
}