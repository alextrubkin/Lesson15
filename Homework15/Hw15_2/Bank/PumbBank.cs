namespace Hw16_2.Bank
{
    public class PumbBank : BankAccount
    {
        public PumbBank(string nameUser, object accountNumber, double balance)
            : base(nameUser, accountNumber, balance)
        {
            NameUser = nameUser;
            AccountNumber = accountNumber;
            Balance = balance;
        }
        public override string NameBank => "PumbBank";
        protected override string NameUser { get; set; }
        protected override object AccountNumber { get; set; }
        protected override double Balance { get; set; }
    }
}
