using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "John", "Bob", "Jane" };

            while (true)
            {
                Console.Write("Please insert new name: ");
                string userName = Console.ReadLine();
                Array.Resize(ref names, names.Length + 1);
                names[names.Length - 1] = userName;
                Console.Write("Do you want to enter another name (Y/N): ");
                string userAnswer = Console.ReadLine();

                while (userAnswer.ToUpper() != "Y" && userAnswer.ToUpper() != "N")
                {
                    Console.WriteLine("You inserted invalid answer");
                    Console.Write("We said Y or N: ");
                    userAnswer = Console.ReadLine();
                }
                if (userAnswer.ToUpper() == "N")
                {
                    break;
                }
            }

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.ReadLine();

        }
    }
}
