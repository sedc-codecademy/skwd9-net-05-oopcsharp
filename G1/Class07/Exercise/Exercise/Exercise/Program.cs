using System;
using Models;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Bob", "Bobsky", Role.Other, 600);
            SalesPerson salesPerson = new SalesPerson("Bill", "Billsky", 1500);
            Manager manager = new Manager("Elon", "Musk", 5000);

            salesPerson.ExtendSuccessRevenue(2000);
            manager.AddBonus(4000);
            salesPerson.ExtendSuccessRevenue(3000);

            Console.WriteLine(employee.GetInfo());
            Console.WriteLine(salesPerson.GetInfo());
            Console.WriteLine(manager.GetInfo());

            Console.WriteLine($"Employee salary: {employee.GetSalary()}");
            Console.WriteLine($"SalesPerson salary: {salesPerson.GetSalary()}");
            Console.WriteLine($"Manager salary: {manager.GetSalary()}");
        }
    }
}
