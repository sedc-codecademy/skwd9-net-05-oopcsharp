using System;

namespace Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }

        public Person(string firstName, string lastName, DateTime dateOfBirth, string address)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Address = address;
        }
    }
}
