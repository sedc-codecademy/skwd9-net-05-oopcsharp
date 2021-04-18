using AcademyAppDomain.Enums;

namespace AcademyAppDomain.Classes
{
    public class User
    {
        public string UserName { get; set; } //unique
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Role Role { get; set; }

        public User(string userName, string firstName, string lastName, int age)
        {
            UserName = userName;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
    }
}
