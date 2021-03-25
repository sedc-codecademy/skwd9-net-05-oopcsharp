using System;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            if (5 > 3)
            {
                Console.WriteLine("5 is greater then 3");
            }
            else 
            {
                Console.WriteLine("5 is not larger then 3"); // Visual studio tells us here that this code will never be executed
            }

            Console.Write("Please enter a number: ");
            int someNumber = int.Parse(Console.ReadLine());

            // if/else if/else 

            if (someNumber > 0)
            {
                Console.WriteLine("number is positive");
            }
            else if (someNumber < 0)
            {
                Console.WriteLine("number is negative");
            }
            else 
            {
                Console.WriteLine("number is zero");
            }

            // switch
            int day = 3;
            switch (day) 
            {
                case 1:
                    Console.WriteLine("Today is Monday"); 
                    break;
                case 2:
                    Console.WriteLine("Today is Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Today is Wednesday");
                    break;
                default:
                    Console.WriteLine("There is no such day!");
                    break;
            }
        }
    }
}
