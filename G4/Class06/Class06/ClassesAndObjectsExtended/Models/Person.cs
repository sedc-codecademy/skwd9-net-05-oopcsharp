using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesAndObjectsExtended.Models
{
    public class Person
    {
        // properties

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }

        // default constructor - no parameters
        public Person()
        {
        }

        // second constructor - with parameters
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            FullName = $"{firstName} {lastName}";
        }

        // methods
        public string PersonInfo()
        {
            return $"The person is {FullName}";
        }
    }
}
