using System;
using Excercise.Classes;

namespace Excercise
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exercise02
            //Console.WriteLine("Please enter dog name");
            //string name = Console.ReadLine();
            //Console.WriteLine("Please enter race");
            //string race = Console.ReadLine();
            //Console.WriteLine("Please enter color");
            //string color = Console.ReadLine();

            //Dog dog = new Dog(name, race, color);

            //Console.WriteLine("Please enter a number between 1-3");
            //switch (Console.ReadLine())
            //{
            //    case "1":
            //        Console.WriteLine(dog.Eat());
            //        break;
            //    case "2":
            //        Console.WriteLine(dog.Play());
            //        break;
            //    case "3":
            //        Console.WriteLine(dog.ChaseTail());
            //        break;
            //    default:
            //        Console.WriteLine("Wrong option");
            //        break;
            //}

            //Dog dog2 = new Dog();
            //Console.WriteLine("Please enter dog name");
            //dog2.Name = Console.ReadLine();
            //Console.WriteLine("Please enter race");
            //dog2.Race = Console.ReadLine();
            //Console.WriteLine("Please enter color");
            //dog2.Color = Console.ReadLine();

            //Console.WriteLine("Please enter a number between 1-3");
            //switch (Console.ReadLine())
            //{
            //    case "1":
            //        Console.WriteLine(dog.Eat());
            //        break;
            //    case "2":
            //        Console.WriteLine(dog.Play());
            //        break;
            //    case "3":
            //        Console.WriteLine(dog.ChaseTail());
            //        break;
            //    default:
            //        Console.WriteLine("Wrong option");
            //        break;
            //}
            #endregion

            Student[] students = new[]
            {
                new Student("Risto", "CA", "G1"),
                new Student("Adis", "CA", "G1"),
                new Student("Darko", "Design", "G6"),
                new Student("Marko", "JS-Academy", "G1"),
                new Student("Petar", "Database Academy", "G4")
            };

            Console.WriteLine("Search:");
            string input = Console.ReadLine();

            foreach (Student student in students)
            {
                if (student.Name == input)
                {
                    Console.WriteLine(student.GetInfo());
                    return;
                }
            }

            Console.WriteLine("Student not found");
        }
    }
}
