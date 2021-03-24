using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfBranches = 12;
            int numberOfApplesPerBranch = 8;
            int basketLimit = 5;

            Console.WriteLine("How many trees do you have?");
            string numberOfTreesString = Console.ReadLine();

            bool successfulConversion = int.TryParse(numberOfTreesString, out int numberOfTrees);

            if (successfulConversion && numberOfTrees >= 1)
            {
                int numberApples = numberOfTrees * numberOfBranches * numberOfApplesPerBranch;

                int numberOfBaskets = numberApples / basketLimit;

                if (numberApples % basketLimit != 0) numberOfBaskets++;

                Console.WriteLine("You need " + numberOfBaskets + " baskets");
            }
            else
            {
                Console.WriteLine("You have entered wrong input!");
            }
        }
    }
}
