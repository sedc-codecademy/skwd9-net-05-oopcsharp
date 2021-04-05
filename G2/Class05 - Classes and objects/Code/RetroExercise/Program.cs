using System;

namespace RetroExercise
{
    class Program
    {
        static bool Substrings()
        {
            string message = "Hello from SEDC CodeAcademy 2021";
            Console.WriteLine("Please enter a number");
            int numOfCharacters;


            if (int.TryParse(Console.ReadLine(), out numOfCharacters) != true)
            {
                Console.WriteLine("You have entered an incorrect format,\nPress any key to try again!");
                return false;
            }
            if (numOfCharacters > message.Length)
            {
                Console.WriteLine("You have entered an incorrect number,\nPress any key to try again!");
                return false;
            }
            string result = message.Substring(0, numOfCharacters);
            Console.WriteLine(result + " " + "length of new string is " + result.Length);
            return true;

        }
        static void Main(string[] args)
        {
            Substrings();
            Console.ReadLine();
        }
    }
}
