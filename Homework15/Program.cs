using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_16
{
    public class Program
    {
        static void Main(string[] args)
        {
            CreditCard<string> creditCard1 = new CreditCard<string>("string id",200);
            CreditCard<int> creditCard2 = new CreditCard<int>(456123, 500);

            ArrayList cards = new ArrayList() {creditCard1, creditCard2 };

            foreach (var item in cards)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
