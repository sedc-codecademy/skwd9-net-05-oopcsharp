using Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Employee
    {
        public Employee(string firstName, string lastName, double salary, Role role)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            Role = role;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        protected double Salary { get; set; }

        //public Manager Friend { get; set; }
        //public Manager[] Friends { get; set; }

        public Role Role { get; set; }

        public void GetInfo()
        {
            Console.WriteLine($"FIRSTNAME: {FirstName}, LASTNAME: {LastName}, SALARY: {Salary}");
        }
        public virtual double GetSalary()
        {
            return Salary;
        }
    }
}
