using System;

namespace Accounts
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var accountsCollection = new Accounts<BaseAccount>();

            accountsCollection[0] = new Account<string>("TTT1145ROP", 4000);
            accountsCollection[1] = new Account<int>(2345, 4500);
            accountsCollection[2] = new Card<string>("1234 1234 1234 1234", 5000);
            accountsCollection[3] = new Account<int>(234545, 3500);
            accountsCollection[4] = new Card<int>(234556, 5500);

            Console.WriteLine(new string('-', 45));

            foreach (var account in accountsCollection)
            {
                Console.WriteLine(account.ToString());
            }

            Console.WriteLine(new string('-', 45));

            foreach (var account in accountsCollection)
            {
                Console.WriteLine(account.ToString());
            }

            Console.WriteLine(new string('-', 45));

            Console.ReadKey();
        }
    }
}
