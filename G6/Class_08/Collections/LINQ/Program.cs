using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>()
            {
                new Person() {FirstName = "John", LastName = "Doe", Age = 22},
                new Person() {FirstName = "Bob", LastName = "Bobsky", Age = 34},
                new Person() {FirstName = "Jane", LastName = "Doe", Age = 18},
                new Person() {FirstName = "Martin", LastName = "Garrix", Age = 16},
                new Person() {FirstName = "Lebron", LastName = "James", Age = 18}
            };
            // WHERE
            List<Person> olderThan23 = people.Where(person => person.Age > 23).ToList();
            //foreach (Person person in olderThan23)
            //{
            //    Console.WriteLine(person.FirstName);
            //};

            //foreach (Person person in people)
            //{
            //    Console.WriteLine(person.FirstName);
            //};

            //List<Person> olderThan18AndStartWithB = people
            //    .Where(person => person.Age > 18)
            //    .Where(person => person.FirstName.StartsWith("B")).ToList();

            List<Person> olderThan18AndStartWithB = people
                .Where(person => person.Age > 18 && person.FirstName.StartsWith("B")).ToList();

            //foreach (var item in olderThan18AndStartWithB)
            //{
            //    Console.WriteLine(item.FirstName);
            //}

            // SELECT

            List<string> peopleFirstNames = people.Select(person => person.FirstName).ToList();
            List<string> peopleFirstNamesOlderThan20 = people
                .Where(person => person.Age > 20)
                .Select(person => person.FirstName)
                .ToList();
            //foreach (var item in peopleFirstNamesOlderThan20)
            //{
            //    Console.WriteLine(item);
            //}

            // FIRST
            // Person personWithAge18 = people.First(person => person.Age == 118);
            Person personWithAge18 = people.FirstOrDefault(person => person.Age == 118);
            if (personWithAge18 == null)
            {
                Console.WriteLine("NOT FOUND");
            } else
            {
                Console.WriteLine(personWithAge18.FirstName);
            }

            // COUNT
            int personAged18 = people.Count(person => person.Age == 180);
            Console.WriteLine(personAged18);
            

            Console.ReadLine();
        }
    }
}
