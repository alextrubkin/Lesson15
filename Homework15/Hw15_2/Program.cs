using Hw16_2.Bank;
using System;
using static Hw16_2.Bank.BankAccount;

namespace Hw16_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MyDelegate<BankAccount> delegateBankAccount = new MyDelegate<BankAccount>(PrintInfo);
            MyDelegate<PumbBank> delegatePumbBank = delegateBankAccount;
            MyDelegate<PrivatBank> delegatePrivatBank = delegateBankAccount;

            delegatePumbBank(new PumbBank("P.V.P.", (1, "One"), 23));
            delegatePrivatBank(new PrivatBank("P.V.O.", (2, "Two"), 137));
            delegatePumbBank(new PumbBank("A.Y.P.", (3, "Three"), 45));
            delegatePrivatBank(new PrivatBank("M.R.O.", (4, "Four"), 17));
            delegatePumbBank(new PumbBank("A.I.S.", (3, "Three"), 367));
            delegatePrivatBank(new PrivatBank("X.J.L.", (5, "Five"), 0));
            delegatePumbBank(new PumbBank("N.Y.C.", (3, "Three"), 35));
            delegatePrivatBank(new PrivatBank("C.E.O.", (6, "Six"), 1));

            Console.ReadKey();
        }
    }
}
