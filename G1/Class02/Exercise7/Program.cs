using System;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a door between 1-3:");
            string door = Console.ReadLine();

            switch (door)
            {
                case "1":
                    Console.WriteLine("You got a new car!");
                    break;
                case "2":
                    Console.WriteLine("You got a new plane!");
                    break;
                case "3":
                    Console.WriteLine("You got a new bike!");
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
    }
}
