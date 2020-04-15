using System;

namespace CarIEnumerable
{
    public class PresentBox<T> : IPresent<T>
    {
        public T Present { get ; set; }

        public PresentBox(T present)
        {
            Present = present;   
        }

        public override string ToString()
        {
            return $"{Present}";
        }

        public void Print()
        {
            Console.WriteLine(  this.ToString());
        }
    }
}
