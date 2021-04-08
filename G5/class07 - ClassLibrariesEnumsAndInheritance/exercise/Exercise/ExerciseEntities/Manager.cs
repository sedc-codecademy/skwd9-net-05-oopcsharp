using System;
using System.Collections.Generic;
using System.Text;
using ExerciseEntities.Enums;

namespace ExerciseEntities
{
    public class Manager : Employee
    {
        private double Bonus { get; set; }

        public Manager(string firstName, string lastName, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Bonus = 0;
            Role = Role.Manager;
            Salary = salary;
        }

        public void AddBonus(double bonus) 
        {
            Bonus += bonus;
        }

        public override double GetSalary() 
        {
            return Salary + Bonus;
        }
    }
}
