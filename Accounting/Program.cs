using System;
using Accounting.ClassLibrary;

namespace Accounting
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AccountList<int> intAccountList = new AccountList<int>();

            intAccountList[0] = new Account<int>(111, 100);
            intAccountList[1] = new Account<int>(222, 50);
            intAccountList[2] = new Account<int>(333, 75);
            intAccountList[3] = new Account<int>(444, 200);

            foreach(Account<int> account in intAccountList)
            {
                account.AddBalance(100);
                Console.WriteLine(account);
            }

            Console.WriteLine("----------------------------------");

            AccountList<string> stringAccountList = new AccountList<string>();

            stringAccountList[0] = new Account<string>("555", 342);
            stringAccountList[1] = new Account<string>("666", 430);
            stringAccountList[2] = new Account<string>("777", 550);
            stringAccountList[3] = new Account<string>("888", 1000);

            foreach(Account<string> account in stringAccountList)
            {
                account.WithdrawBalance(50);
                Console.WriteLine(account);
            }

            Console.ReadKey();
        }
    }
}
