using System.Collections;

namespace Cars
{
    public class Cars : IEnumerable
    {
        private readonly Car[] cars;

        public Cars(Car[] newCars)
        {
            cars = newCars;
        }

        public Car this[int index]
        {
            get => cars[index];
            set
            {
                cars[index] = value;
            }
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
