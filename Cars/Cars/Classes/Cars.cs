using System.Collections;

namespace Cars
{
    public class Cars<T> : IEnumerable where T : Car
    {
        private readonly T[] cars;

        public Cars()
        {
            cars = new T[4];
        }

        public T this[int index]
        {
            get => cars[index];
            set
            {
                cars[index] = value;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (var car in cars)
            {
                yield return car;
            }
        }
    }
}
