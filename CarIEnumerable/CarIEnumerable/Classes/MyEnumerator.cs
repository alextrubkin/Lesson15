using System.Collections;
using System.Collections.Generic;


namespace CarIEnumerable
{
    public class MyEnumerator :IEnumerator<int>
    {
        private int _itemCount;//максимальное количество єлементов последовательности
        private int _current;// текущее значение последовательности
        private int _pozition;//указатель на текущее значение

        public MyEnumerator(int itemCount)
        {
            _itemCount = itemCount;
            _current = 0;
            _pozition=0;
        }

        public int Current => _current;

        object IEnumerator.Current => Current;

        public void Dispose()
        {
           
        }

        public bool MoveNext()
        {
            if (_pozition < _itemCount)
            {
                _current += 2;
                _pozition++;
                return true;
            }
            else
                Reset();
                return false;
        }

        public void Reset()
        {
            _current = 0;
            _pozition =0;
        }
    }
}
