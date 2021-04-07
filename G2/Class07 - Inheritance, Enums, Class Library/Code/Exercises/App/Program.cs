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
            Console.ReadLine();
        }
    }
}
