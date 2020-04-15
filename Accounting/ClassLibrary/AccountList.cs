using System.Collections;

namespace Accounting.ClassLibrary
{
    public class AccountList<T> : IEnumerable, IEnumerator
    {
        private int position = -1;

        readonly Account<T>[] accounts;

        public AccountList()
        {
            accounts = new Account<T>[4];
            Length = accounts.Length;
        }

        public Account<T> this[int index]
        {
            get => accounts[index];
            set => accounts[index] = value;
        }

        public int Length { get; }

        object IEnumerator.Current => accounts[position];

        bool IEnumerator.MoveNext()
        {
            if (position < accounts.Length - 1)
            {
                position++;
                return true;
            }
            ((IEnumerator)this).Reset();
            return false;
        }

        void IEnumerator.Reset()
        {
            position = -1;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (Account<T> account in accounts)
            {
                yield return account;
            }
        }
    }
}
