using System;

namespace DZ_8_Tumakov
{
    public class BankTransaction
    {
        //Упражнение 13.1 Изменить класс BankTransaction, созданный для хранений финансовых
        //операций со счетом, - заменить методы доступа к данным на свойства для чтения.
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
