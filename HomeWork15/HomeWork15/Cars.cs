using System.Collections;

namespace HomeWork15
{
    public class Cars<T> : IEnumerable
    {
        readonly T[] cars = new T[5];

        public T this[int index]
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

        IEnumerator IEnumerable.GetEnumerator()
        {
            return cars.GetEnumerator();
        }

        public IEnumerable YieldImplementation()
        {
            for (int i = 0; i < cars.Length; i++)
            {
                yield return cars[i];
            }
        }
    }
}

