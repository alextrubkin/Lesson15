namespace Accounts
{
    public class Card<T> : BaseAccount
    {
        public Card(T cardNumber, int balance) : base(balance)
        {
            CardNumber = cardNumber;
        }

        public T CardNumber { get; set; }
        public override string ToString()
        {
            return $"Account with card number \"{CardNumber}\" and balance = {Balance}";
        }
    }
}
