using ClassLibrary.Models;
using System;

namespace CompanyApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee[] company = new Employee[]
            {
                new Menager("Bob", "Bobski"),
                new SalesPerson("John", "Dow"),
                new SalesPerson("Rick", "Brown")
            };

            Menager bob = (Menager)company[0];
            bob.AddBonus(5000);
            Console.WriteLine(bob.GetSalary());
            bob.PrintInfo();

            SalesPerson john = (SalesPerson)company[1];
            john.AddSuccessRevenue(5500);
            Console.WriteLine(john.GetSalary());
            john.GetSalary();
            john.PrintInfo();












            Console.ReadLine();
        }
    }
}
