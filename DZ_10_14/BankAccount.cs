using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_10_14
{
    internal class BankAccount
    {
        public int AccountNumber { get; private set; }
        public string AccountType { get; private set; }
        public string AccountHolder { get; set; }
        public List<BankTransaction> Transactions { get; private set; } = new List<BankTransaction>();

        public BankAccount(int accountNumber, string accountType)
        {
            AccountNumber = accountNumber;
            AccountType = accountType;
        }

        public BankTransaction this[int index]
        {
            get
            {
                return Transactions[index];
            }
        }

        [Conditional("DEBUG_ACCOUNT")]
        public void DumpToScreen()
        {
            Console.WriteLine($"Номер: {AccountNumber}");
            Console.WriteLine($"Тип: {AccountType}");
            Console.WriteLine($"Владелец: {AccountHolder}");
            Console.WriteLine($"Номер транзакции: {Transactions.Count}");

            foreach (var transaction in Transactions)
            {
                Console.WriteLine($"  Дата: {transaction.Date}, Сумма: {transaction.Amount}, Описание: {transaction.Description}");
            }
        }
    }
}
