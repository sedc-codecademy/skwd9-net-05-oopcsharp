using ClassesAndObjectsExtended.Models;
using System;

namespace ClassesAndObjectsExtended
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Person student01 = new Person();
            student01.FirstName = "Bob";
            student01.LastName = "Bobsky";
            Console.WriteLine(student01.FirstName);

            Person student02 = new Person("Blazo", "Blazov");
            Console.WriteLine(student02.PersonInfo());

            Person[] students = new Person[]
            {
                new Person("Jana", "Simjanovska"),
                new Person("Leart", "Kamberi"),
                new Person("Nikola", "Sheskokalov")
            };

            foreach (Person item in students)
            {
                Console.Write($"{item.FirstName} ");
            }

            Console.ReadLine();
        }
    }
}
