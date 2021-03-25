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

            //exercise 5
            var n = 8;
            var m = 5;

            var trees = int.Parse(Console.ReadLine());

            var allApples = n * 12 * trees;

            int result;

            if (allApples % m == 0)
            {
                result = allApples / m;
            }
            else 
            {
                result = (allApples / m) + 1;
            }

            Console.WriteLine(result);
        }
    }
}
