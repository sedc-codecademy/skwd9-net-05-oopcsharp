using ExerciseEntities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseEntities
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        protected double Salary { get; set; }
        public Role Role { get; set; }

        public Employee()
        {
            Salary = 0;
        }

        public void PrintInfo() 
        {
            Console.WriteLine($"FirstName: {FirstName}, LastName: {LastName}, Salary: {Salary}");
        }

        public virtual double GetSalary() 
        {
            return Salary;
        }
    }
}
