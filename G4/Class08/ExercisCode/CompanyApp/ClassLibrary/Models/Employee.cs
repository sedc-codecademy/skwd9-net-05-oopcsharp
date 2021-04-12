using ClassLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Models
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public CompanyRole Role { get; set; }
        protected double Salary { get; set; }

        public Employee()
        {

        }

        public void PrintInfo()
        {
            Console.WriteLine($"First Name: {FirstName}, Last Name: {LastName}, Salary: {Salary}");
        }

        public virtual double GetSalary()
        {
            return Salary;
        }
    }
}
