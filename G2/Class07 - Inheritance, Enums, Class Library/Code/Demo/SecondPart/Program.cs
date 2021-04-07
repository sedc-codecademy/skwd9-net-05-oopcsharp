using SecondPartDomain.Classes;
using SecondPartDomain.Enums;
using System;

namespace SecondPart
{
    class Program
    {
        static Person[] FindPeopleBornOnFriday(Person[] personArray)
        {
            Person[] found = new Person[0];
            int counter = 0;
            foreach(Person person in personArray)
            {
                //if(person.DayOfBirth == (DaysOfWeekEnum)5)
                if(person.DayOfBirth == DaysOfWeekEnum.Friday)
                {
                    Array.Resize(ref found, found.Length + 1);
                    found[counter] = person;
                    counter++;
                }
            }
            return found;
        }
        static void Main(string[] args)
        {
            Person bill = new Person("Bill", "Berry", 20, DaysOfWeekEnum.Friday);
            Person kate = new Person("Kate", "Berry", 19, DaysOfWeekEnum.Wednesday);
            Person paul = new Person("Paul", "Fisher", 30, DaysOfWeekEnum.Friday);

            Person[] people = new Person[]
            {
                bill,
                kate,
                paul
            };
            Person[] peopleBornOnFriday = FindPeopleBornOnFriday(people);
            foreach(Person person in peopleBornOnFriday)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName}");
            }
            Console.ReadLine();
        }
    }
}
