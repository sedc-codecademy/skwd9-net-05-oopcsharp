using AcademyLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademyLibrary.Models
{
    public class Participant
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public AcademyRole Role { get; set; }

        public Participant()
        {

        }
        public Participant(string firstName, string lastName, int age, AcademyRole role)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Role = role;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"This is participant {FirstName} {LastName}, {Age} years old.");
        }
    }
}
