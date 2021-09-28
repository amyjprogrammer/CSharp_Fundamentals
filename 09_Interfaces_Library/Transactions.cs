using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Interfaces_Library
{
    public class Transactions
    {
        private readonly ICurrency _currency;

        public Transactions(ICurrency currency)
        {
            _currency = currency;
            DateOfTransaction = DateTimeOffset.Now;
        }

        public DateTimeOffset DateOfTransaction { get; set; }

        public decimal GetTransactionAmount()
        {
            return _currency.Value;
        }

        public string GetTransactionType()
        {
            return _currency.Name;
        }
    }
}
