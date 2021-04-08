using ExerciseEntities;
using ExerciseEntities.Enums;
using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee()
            {
                FirstName = "Bob",
                LastName = "Bobsky",
                Role = Role.Other
            };

            var employeeSalary = employee.GetSalary();

            SalesPerson salesPerson = new SalesPerson("Bill", "Billsky");
            salesPerson.AddSuccessRevenue(3500);

            var salesPersonSalary = salesPerson.GetSalary();

            Manager manager = new Manager("Elon", "Musk", 5000);
            manager.AddBonus(2000);

            var managerSalary = manager.GetSalary();

            Console.ReadLine();
        }
    }
}
