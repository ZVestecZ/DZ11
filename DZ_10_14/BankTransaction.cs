using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_10_14
{
    internal class BankTransaction
    {
        public DateTime Date { get; private set; }
        public decimal Amount { get; private set; }
        public string Description { get; private set; }

        public BankTransaction(DateTime date, decimal amount, string description)
        {
            Date = date;
            Amount = amount;
            Description = description;
        }
    }
}
