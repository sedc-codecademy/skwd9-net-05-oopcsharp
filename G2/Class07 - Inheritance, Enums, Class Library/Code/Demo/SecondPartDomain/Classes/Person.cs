using SecondPartDomain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SecondPartDomain.Classes
{
    public class Person
    {
        private int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DaysOfWeekEnum DayOfBirth { get; set; }

        public Person(string firstName, string lastName, int age, DaysOfWeekEnum dayOfBirth)
        {
            Id = new Random().Next(1, 99999);
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            DayOfBirth = dayOfBirth;
        }
    }
}
