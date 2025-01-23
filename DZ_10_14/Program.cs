using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_10_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 14.1

            BankAccount account = new BankAccount(12345, "Checking");
            account.AccountHolder = "John Doe";
            account.Transactions.Add(new BankTransaction(DateTime.Now, 1000, "Deposit"));
            account.Transactions.Add(new BankTransaction(DateTime.Now.AddDays(-1), 500, "Withdrawal"));

            account.DumpToScreen();


            //Задание 14.2
            Console.WriteLine("Задание 14.2");

            Type rationalNumberType = typeof(RationalNumber);
            DeveloperInfAttribute[] attributes = (DeveloperInfAttribute[])rationalNumberType.GetCustomAttributes(typeof(DeveloperInfAttribute), true);

            foreach (DeveloperInfAttribute attribute in attributes)
            {
                Console.WriteLine($"Разработчик: {attribute.DeveloperName}, Дата разработки: {attribute.DateDeveloped.ToShortDateString()}");
            }

            Console.ReadKey();

            //Домашние задание 14.1
            Console.WriteLine("Домашние задание 14.1");

            Type buildingType = typeof(Building);
            DeveloperInfoAttribute[] attributes1 = (DeveloperInfoAttribute[])buildingType.GetCustomAttributes(typeof(DeveloperInfoAttribute), true);

            Console.WriteLine($"Разработчик: {attributes1[0].DeveloperName}");
            Console.WriteLine($"Организация: {attributes1[0].OrganizationName}");
            Building building1 = new Building("ул. а, 1", 10, 100);
            Console.WriteLine($"{building1.Address}, {building1.Floors}, {building1.NumberOfApartments}");

            Console.ReadKey();
        }
    }
}
