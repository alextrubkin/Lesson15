using System.Collections;

namespace Accounts
{
    public class Accounts<T> : IEnumerable where T : BaseAccount
    {
        private readonly T[] accounts;

        public Accounts()
        {
            accounts = new T[5];
        }

        public T this[int index]
        {
            get => accounts[index];
            set
            {
                accounts[index] = value;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (var account in accounts)
            {
                yield return account;
            }
        }
    }
}
