using DZ_8_Tumakov;
using System;
using System.Collections.Generic;

namespace DZ_10_13
{
    public class BankAccount
    {
        //Упражнение 13.1 заменить методы на свойства только для чтения
        public int AccountNumber { get; private set; }
        public string AccountType { get; private set; }
        public string AccountHolder { get; private set; }
        public List<BankTransaction> Transactions { get; private set; } = new List<BankTransaction>();

        public BankAccount(int accountNumber, string accountType)
        {
            AccountNumber = accountNumber;
            AccountType = accountType;
        }

        //Упражнение 13.2 Добавить индексатор в класс
        public BankTransaction this[int index]
        {
            get
            {
                return Transactions[index];
            }
        }
    }
}
