using System.Collections;

namespace CollectionsTask_Console.Collection
{
    public class Cars<T> : IEnumerable, IEnumerator
    {
        private int position = -1;

        readonly T[] cars;

        public Cars()
        {
            cars = new T[4];
            Length = cars.Length;
        }

        public T this[int index]
        {
            get => cars[index];
            set => cars[index] = value;
        }

        public int Length { get; }

        object IEnumerator.Current => cars[position];

        bool IEnumerator.MoveNext()
        {
            if(position < cars.Length - 1)
            {
                position++;
                return true;
            }
            ((IEnumerator)this).Reset();
            return false;
        }

        void IEnumerator.Reset()
        {
            position = -1;
        }

        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    return (IEnumerator)this;
        //}

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach(T car in cars)
            {
                yield return car;
            }
        }
    }
}
