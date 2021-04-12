using System;
using System.Collections.Generic;
using System.Text;
using Models.Enums;

namespace Models
{
    public class Manager : Employee
    {
        public Manager(string firstName, string lastName, double salary)
            : base(firstName, lastName, salary, Role.Manager) { }

        private double Bonus { get; set; }

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
