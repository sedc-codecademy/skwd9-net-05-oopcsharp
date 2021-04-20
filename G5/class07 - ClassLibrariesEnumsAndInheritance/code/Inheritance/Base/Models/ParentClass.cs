using System;
using System.Collections.Generic;
using System.Text;

namespace Base.Models
{
    public class ParentClass
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ParentClass(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
