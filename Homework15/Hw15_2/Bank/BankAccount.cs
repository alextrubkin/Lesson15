using System;

namespace Hw16_2.Bank
{
    public class BankAccount
    {
        public BankAccount(string nameUser, object accountNumber, double balance)
        {
            NameUser = nameUser;
            AccountNumber = accountNumber;
            Balance = balance;


        }
        public delegate void MyDelegate<in T>(T bankAccount);
        public virtual string NameBank { get; set; }
        protected virtual string NameUser { get; set; }
        protected virtual object AccountNumber { get; set; }
        protected virtual double Balance { get; set; }

        public override string ToString()
        {
            return $"Bank : \t{NameBank} " +
                $"\t | name user: {NameUser} " +
                $"\t | account number: {AccountNumber} " +
                $"\t | balance: {Balance} \n{new string('-', 100)}\n";
        }

        public static void PrintInfo(BankAccount bankAccount)
        {
            Console.WriteLine(bankAccount.ToString());
        }

    }
}
