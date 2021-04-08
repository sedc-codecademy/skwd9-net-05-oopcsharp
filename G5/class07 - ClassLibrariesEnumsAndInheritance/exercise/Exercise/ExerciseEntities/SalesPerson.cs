using System;
using System.Collections.Generic;
using System.Text;
using ExerciseEntities.Enums;

namespace ExerciseEntities
{
    public class SalesPerson : Employee
    {
        private double SuccessSaleRevenue { get; set; }

        public SalesPerson(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = 500;
            Role = Role.Sales;
        }

        public void AddSuccessRevenue(double input) 
        {
            SuccessSaleRevenue += input;
        }

        public override double GetSalary() 
        {
            if (SuccessSaleRevenue <= 2000)
            {
                return Salary + 500;
            }
            else if (SuccessSaleRevenue > 2000 || SuccessSaleRevenue <= 5000)
            {
                return Salary + 1000;
            }
            else if (SuccessSaleRevenue > 5000)
            {
                return Salary + 1500;
            }
            else 
            {
                return Salary;
            }
        }
    }
}
