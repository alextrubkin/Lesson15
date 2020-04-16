
using System.Collections;


namespace HomeWork_15
{
    public class CarsInfo<T> : IEnumerable
    {
        
        public T[] cars = new T[6];

        public T this[int index]
        {
            get=>cars[index];            
            set=>cars[index] = value;            
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return cars.GetEnumerator();
        }      
        public IEnumerable RealizationYield()
        {
            for (int i = 0; i < cars.Length - 1; i++)
            {
                yield return cars[i];
            }
        }
    }
}
