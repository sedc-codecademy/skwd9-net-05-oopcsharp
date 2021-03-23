using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // prints in console and leaves a line after the text
            Console.WriteLine("Hello G4! We are learning C#!");
            Console.WriteLine("Hello again!");
            // prints in console and does NOT leave a line after the text
            Console.Write("Kristina");
            Console.Write("Panche");

            // waits for user input - does not close the console
            Console.ReadLine();
        }
    }
}
