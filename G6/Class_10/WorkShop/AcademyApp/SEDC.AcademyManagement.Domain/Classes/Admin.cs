using AcademyAppDomain.Enums;
namespace AcademyAppDomain.Classes
{
    public class Admin : User
    {
        public Admin(string userName, string firstName, string lastName, int age) : base(userName, firstName, lastName, age)
        {
            Role = Role.Admin;
        }
    }
}
