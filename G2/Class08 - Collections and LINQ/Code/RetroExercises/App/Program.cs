using Domain.Classes;
using Domain.Enums;
using System;

namespace App
{
    class Program
    {
        public bool IsManager(Employee employee)
        {
            return employee.Role == RoleEnum.Manager;
        }
        static void Main(string[] args)
        {
            Employee employee = new Employee()
            {
                FirstName = "Marko",
                LastName = "Markovski",
                Role = RoleEnum.Manager
            };
            Console.WriteLine(employee.GetInfo());

            SalesPerson salesPerson = new SalesPerson("Bill", "Madison");
            salesPerson.AddSuccessRevenue(400);
            Console.WriteLine(salesPerson.GetSalary());

            Manager manager = new Manager("Vilie", "Peterson", 1200);
            Console.WriteLine(manager.GetSalary());
            manager.AddBonus(200);
            manager.AddBonus(300);
            Console.WriteLine(manager.GetSalary());

            Console.ReadLine();
        }
    }
}
