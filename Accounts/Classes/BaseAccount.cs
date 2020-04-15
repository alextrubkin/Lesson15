namespace Accounts
{
    public abstract class BaseAccount
    {
        public BaseAccount(int balance)
        {
            Balance = balance;
        }

        public int Balance { get; set; }
    }
}
