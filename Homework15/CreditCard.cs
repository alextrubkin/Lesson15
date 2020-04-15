using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_16
{
    public class CreditCard<T>
    {
        public T ID { get; set; }
        public decimal Deposit { get; set; }

        public CreditCard(T id, decimal deposit)
        {
            ID = id;
            Deposit = deposit;
        }


        public override string ToString()
        {
            return $"Card id: {ID}, deposit: {Deposit} $.";
        }
    }
}
