using System.Collections;
using System.Collections.Generic;

namespace Homework15_Library
{
    public class Cars<T> : IEnumerable where T : Car
    {
        private List<T> CarsColletion { get; set; }
        public int Length { get => CarsColletion.Count; }


        public Cars()
        {
            CarsColletion = new List<T>();
        }


        public IEnumerator GetEnumerator()
        {
            return CarsColletion.GetEnumerator();
        }

        public IEnumerable GetCarsInfo()
        {

            for (int i = 0; i < Length; i++)
            {
                yield return CarsColletion[i];
            }
            yield break;
        }

        public IEnumerable GetCarsInfo(int idMultiply)
        {

            for (int i = 0; i < Length; i++)
            {
                if (CarsColletion[i].ID % idMultiply == 0)
                {
                    yield return CarsColletion[i];
                }
            }
            yield break;
        }

        public void Add(params T[] items)
        {
            CarsColletion.AddRange(items);
        }
    }
}
