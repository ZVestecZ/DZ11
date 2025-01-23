using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_10_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Домашнее задание 13.1
            Console.WriteLine("Домашнее задание 13.1");

            Building building1 = new Building("ул. а, 1", 10, 100);
            Console.WriteLine($"{building1.Address}, {building1.Floors}, {building1.NumberOfApartments}");

            building1.Address = "пр. б, 2";
            building1.Floors = 15;
            building1.NumberOfApartments = 150;

            Console.WriteLine($"{building1.Address}, {building1.Floors}, {building1.NumberOfApartments}");


            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //Домашнее задание 13.2
            Console.WriteLine("Домашнее задание 13.2");

            BuildingsCollection buildingsCollection = new BuildingsCollection();
            buildingsCollection[0] = new Building("ул. в, 1", 5, 50);
            buildingsCollection[1] = new Building("ул. г, 2", 10, 100);

            Console.WriteLine($"Дом 0: {buildingsCollection[0].Address}");
            Console.WriteLine($"Дом 1: {buildingsCollection[1].Address}");



            Console.ReadKey();
        }
    }
}
