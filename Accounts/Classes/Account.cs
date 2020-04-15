namespace Accounts
{
    public class Account<T>: BaseAccount
    {
        public Account(T accountNumber, int balance) : base(balance)
        {
            AccountNumber = accountNumber;
        }

        public T AccountNumber { get; set; }

        public override string ToString()
        {
            return $"Account with account number \"{AccountNumber}\" and balance = {Balance}";
        }
    }
}
