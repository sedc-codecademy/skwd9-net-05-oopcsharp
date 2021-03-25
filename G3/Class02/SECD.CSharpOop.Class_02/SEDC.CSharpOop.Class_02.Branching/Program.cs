using System;

namespace SEDC.CSharpOop.Class_02.Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            // Excersise 5

            Console.WriteLine("Enter how much trees you have");
            string userInput = Console.ReadLine();
            int branchesPerTree = 12;
            int applesPerBranch = 8;
            int applesPerBasket = 5;

            int numberOfTrees = 0;
            bool isValidInput = int.TryParse(userInput, out numberOfTrees);

            if(isValidInput)
            {
                int totalBasets = ((numberOfTrees * branchesPerTree) * applesPerBranch) / applesPerBasket;
                int applesLeft = ((numberOfTrees * branchesPerTree) * applesPerBranch) % applesPerBasket;

                if(applesLeft > 0)
                {
                    totalBasets++;
                }
                Console.WriteLine("Total baskets: " + totalBasets);
            }
            else
            {
                Console.WriteLine("Please enter valid input");
            }

            // Excersise 6

            Console.WriteLine("Please enter the first number");
            string userInput1 = Console.ReadLine();
            Console.WriteLine("Please enter the second number");
            string userInput2 = Console.ReadLine();

            int num1 = 0;
            bool isValidFirstNumber = int.TryParse(userInput1, out num1);
            // this is the same with prev line
            bool isValidSecondNumber = int.TryParse(userInput2, out int num2);

            if(isValidFirstNumber && isValidSecondNumber)
            {
                // check witch number is larger
                if(num1 > num2)
                {
                    Console.WriteLine("Number " + num1 + " is larger that " + num2);
                }
                else
                {
                    Console.WriteLine("Number " + num2 + " is larger that " + num1);
                }

                if(num1 % 2 == 0)
                {
                    Console.WriteLine("Number1 is even");
                }
                else
                {
                    Console.WriteLine("Number1 is odd");
                }

                if(num2 % 2 == 0)
                {
                    Console.WriteLine("Number2 is even");
                }
                else
                {
                    Console.WriteLine("Number2 is odd");
                }
            }
            else
            {
                Console.WriteLine("Plese enter valid numbers");
            }


            Console.WriteLine("Eureka :) ");
            Console.ReadLine();
        }
    }
}
