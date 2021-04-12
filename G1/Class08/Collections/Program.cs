using System;
using System.Collections.Generic;
using Models;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1, Martin
            // 2, Ivan
            // 3, Goran
            Dictionary<int, string> students = new Dictionary<int, string>
            {
                {1, "Martin" },
                {2, "Ivan" },
                {3, "Goran" },
                {6, "Aleksandar" }
            };

            //Console.WriteLine("Please enter student card:");
            //string cardString = Console.ReadLine();
            //Console.WriteLine("Please enter student name:");
            //string name = Console.ReadLine();

            //if (!int.TryParse(cardString, out int card))
            //{
            //    Console.WriteLine("Wrong input.");
            //    return;
            //}

            ////students.Add(card, name);
            ////bool successfulAdd = students.TryAdd(card, name);

            //bool keyExists = students.ContainsKey(card);

            //if (!keyExists)
            //{
            //    students.Add(card, name);
            //}

            string student = students[6];
            //students.Remove(6);

            //students.Remove(6, out string student);

            foreach (KeyValuePair<int, string> s in students)
            {
                Console.WriteLine($"{s.Key}: {s.Value}");
            }

            Dictionary<string, Person> citizens = new Dictionary<string, Person>();

            citizens.Add("A000111", new Person("Risto", "Panchevski", new DateTime(1989, 7, 20), "Gjorce"));
            citizens.Add("A999111", new Person("Adis", "Drndar", new DateTime(1999, 01, 01), "Gjorce"));

            foreach (KeyValuePair<string, Person> citizen in citizens)
            {
                Console.WriteLine($"LK. {citizen.Key}, {citizen.Value.FullName}");
            }
        }
    }
}
