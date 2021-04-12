using Domain.Enums;

namespace Domain.Classes
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        protected double Salary { get; set; }
        public RoleEnum Role { get; set; }

        public Employee()
        {
            Salary = 600;
        }

        public string GetInfo()
        {
            return $"{FirstName} {LastName} {Role}";
        }

        public virtual double GetSalary()
        {
            return Salary;
        }
    }
}
