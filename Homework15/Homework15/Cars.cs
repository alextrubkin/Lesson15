using System.Collections;

namespace Homework15
{
    public class Cars<T> : IContainer<T>, IEnumerable
    {

        readonly Car[] cars;
        private T car;
        public Cars(T car)
        {
            this.car = car;
        }

        public T Car
        {
            set { car = value; }
        }

        T IContainer<T>.Cars { get; }

        public override string ToString()
        {
            return car.ToString();
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