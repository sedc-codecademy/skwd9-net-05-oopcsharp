using AcademyAppDomain.Enums;
namespace AcademyAppDomain.Classes
{
    public class Trainer : User
    {
        public Trainer(string userName, string firstName, string lastName, int age) : base(userName, firstName, lastName, age)
        {
            Role = Role.Trainer;
        }
    }
}
