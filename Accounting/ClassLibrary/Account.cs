namespace Accounting.ClassLibrary
{
    public class Account<T>
    {
        public T Id { get; set; }
        public int Balance { get; set; }

        public Account(T id, int balance)
        {
            Id = id;
            Balance = balance;
        }

        public void AddBalance(int amount)
        {
            Balance += amount;
        }

        public void WithdrawBalance(int amount)
        {
            Balance -= amount;
        }

        public override string ToString()
        {
            return $"Account #{Id}, current balance: {Balance}";
        }
    }
}
