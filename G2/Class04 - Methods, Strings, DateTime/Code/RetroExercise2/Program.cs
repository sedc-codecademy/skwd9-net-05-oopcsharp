using System;

namespace RetroExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fullNames = new string[0];
            int counter = 0;
            while (true)
            {
                Console.WriteLine("Please enter a name from the keyboard:");
                string name = Console.ReadLine();
                Array.Resize(ref fullNames, fullNames.Length + 1);
                fullNames[counter] = name;
                Console.WriteLine("Names stored:");
               
                Console.WriteLine("Do you want to enter another name?");
                string input = Console.ReadLine();
                if (input == "N" || input == "n") 
                    break;

                counter++;
            }

            foreach (string currentName in fullNames)
            {
                Console.WriteLine(currentName);
            }

            Console.ReadLine();
        }
    }
}
