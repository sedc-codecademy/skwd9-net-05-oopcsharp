using System;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            Console.WriteLine("Enter an input");
            string stringInput = Console.ReadLine();
            bool parsingResult = int.TryParse(stringInput, out input);

            if (parsingResult)
            {
                if (input > 0)
                {
                    Console.WriteLine("The input is a positive number");
                }
                else if (input < 0)
                {
                    Console.WriteLine("The input is a negative number");
                }
                else
                {
                    Console.WriteLine("The input is zero");
                }
            }
            else
            {
                Console.WriteLine("An error occured! The input is not a whole number!");
            }
            Console.WriteLine("===SWITCH===");
            //SWITCH
            //int day = 3;
            Console.WriteLine("Enter a day");
            int day = int.Parse(Console.ReadLine());
            switch (day)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Working day!");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("Weekend!");
                    break;
                default:
                    Console.WriteLine("Wrong input!");
                    break;
            }

            //Console.WriteLine(5=="5"); - not the same type, comparison is not allowed

            Console.ReadLine();
        }
    }
}
