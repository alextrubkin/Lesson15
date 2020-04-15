
using System.Collections;

namespace CarIEnumerable
{
    public class CarCollection : IEnumerable, IEnumerator
    {
        //создание простой пользовательской коллекции
        private Car[] carsArray = new Car[4];
        //public Car[] carsArray = new Car[4];
        //public List<Car> carsList = new List<Car>();
        public Car this[int index]
        {
            get { return carsArray[index]; }
            set { carsArray[index] = value; }

        }
        int position = -1;
         object IEnumerator.Current => carsArray[position];

        //public CarCollection GetEnumerator()
        //{
        //    return this;
        //}

         IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator) this;
        }

        bool IEnumerator.MoveNext()
        {
            if (position < carsArray.Length - 1)
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

        
    }
}
