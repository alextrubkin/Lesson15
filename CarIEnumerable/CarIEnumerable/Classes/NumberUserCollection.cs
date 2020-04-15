using System.Collections;
using System.Collections.Generic;


namespace CarIEnumerable
{
     public class NumberUserCollection:IEnumerable<int>,IHeap
    {        
        private  static int _itemCount;
        
        private int[] numbersArray = new int[_itemCount];

        public NumberUserCollection(int itemCount)
        {
            _itemCount = itemCount;  
        }


        public int this[int index]
        {
            get { return numbersArray[index]; }
            set { numbersArray[index] = value; }
        }


        public IEnumerator<int> GetEnumerator()
        {
            return new MyEnumerator(_itemCount);
        }

        public string GetMyStrings()
        {
            string answer = "My enjoined numbers: ";
            foreach (var numb in this)
            {
                answer += numb + " ";               
            }            
            return answer;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
