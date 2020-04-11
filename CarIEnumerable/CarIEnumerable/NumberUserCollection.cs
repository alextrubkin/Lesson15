using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarIEnumerable
{
     public class NumberUserCollection:IEnumerable<int>//парковка
    {        
        private  static int _itemCount;
        
        private Car[] carsArray = new Car[_itemCount];

        public NumberUserCollection(int itemCount)// макс количество машин на стоянке
        {
            _itemCount = itemCount;  
        }


        public Car this[int index]
        {
            get { return carsArray[index]; }
            set { carsArray[index] = value; }
        }


        public IEnumerator<int> GetEnumerator()
        {
            return new MyEnumerator(_itemCount);
        }       

       

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
