using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsTask_Console.Collection
{
    public class Cars : IEnumerable, IEnumerator
    {
        private int position = -1;

        readonly Car[] cars;

        public Cars()
        {
            cars = new Car[4];
            Length = cars.Length;
        }

        public Car this[int index]
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
            foreach(Car car in cars)
            {
                yield return car;
            }
        }
    }
}
