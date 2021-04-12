using Models;
using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            SalesPerson salesPerson = new SalesPerson("John", "Doe", 1500);
            Manager manager = new Manager("Bob", "Bobsky", 2500);

            salesPerson.AddSuccessRevenue(2000);
            double salesPersonSalary = salesPerson.GetSalary();
            // Console.WriteLine(salesPersonSalary);

            manager.AddBonus(200);
            manager.AddBonus(5000);
            double managerSalary = manager.GetSalary();
            Console.WriteLine(managerSalary);
            Console.ReadLine();
        }
    }
}
