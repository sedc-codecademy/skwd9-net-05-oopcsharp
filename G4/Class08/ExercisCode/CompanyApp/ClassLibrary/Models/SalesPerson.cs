using ClassLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Models
{
    public class SalesPerson : Employee
    {
        private double SuccessSaleRevenue { get; set; }

        public SalesPerson()
        {

        }

        public SalesPerson(string firstName, string lastName) 
        {
            FirstName = firstName;
            LastName = lastName;
            Role = CompanyRole.Sales;
            Salary = 500;
        }

        public void AddSuccessRevenue(double num)
        {
            SuccessSaleRevenue = num;
        }

        public override double GetSalary()
        {
            if (SuccessSaleRevenue <= 2000)
            {
                Salary = Salary + 500;
                return Salary ;
            } else if (SuccessSaleRevenue > 2000 && SuccessSaleRevenue <= 5000)
            {
                Salary = Salary + 1000;
                return Salary;
            }
            else
            {
                Salary = Salary + 1500;
                return Salary;
            }
        }
    }
}
