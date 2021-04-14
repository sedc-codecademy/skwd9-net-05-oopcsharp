using ClassLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Models
{
    public class Menager : Employee
    {
        private double Bonus { get; set; }

        public Menager()
        {

        }

        public Menager(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Role = CompanyRole.Menager;
            Salary = 2000;
        }

        public void AddBonus(int num)
        {
            Bonus = num;
        }

        public override double GetSalary()
        {
            Salary = Salary + Bonus;
            return Salary;
        }
    }
}
