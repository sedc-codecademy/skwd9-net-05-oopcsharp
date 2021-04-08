using System;
using System.Collections.Generic;
using System.Text;
using Models.Enums;

namespace Models
{
    public class SalesPerson : Employee
    {
        public SalesPerson(string firstName, string lastName, double saleRevenue)
              : base(firstName, lastName, 500, Role.Sales)
        {
            SuccessSaleRevenue = saleRevenue;
        }
        private double SuccessSaleRevenue { get; set; }

        public void AddSuccessRevenue(double revenue)
        {
            SuccessSaleRevenue += revenue;
        }

        public override double GetSalary()
        {
            double bonus = 0;
            if (SuccessSaleRevenue <= 2000)
            {
                bonus = 500;
            } else if (SuccessSaleRevenue > 2000 && SuccessSaleRevenue <= 5000) {
                bonus = 1000;
            } else if (SuccessSaleRevenue > 5000)
            {
                bonus = 1500;
            }

            return Salary + bonus;
        }

    }
}
