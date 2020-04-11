using System.Collections;
using System.Collections.Generic;

namespace Homework15
{
    public class Cars : IEnumerable
    {
        private List<Car> CarsColletion { get; set; }
        public int Length { get => CarsColletion.Count; }


        public Cars()
        {
            CarsColletion = new List<Car>();
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

        public void Add(params Car[] cars)
        {
            CarsColletion.AddRange(cars);
        }
    }
}
