using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            Console.Write("Enter human first name:");
            human.FirstName = Console.ReadLine();
            Console.Write("Enter human last name:");
            human.LastName = Console.ReadLine();
            Console.Write("Enter human age:");
            //this will give an exception if the input is incorrect
            human.Age = int.Parse(Console.ReadLine());

            Console.WriteLine(human.GetPersonStats());

            Console.ReadLine();
        }
    }
}
