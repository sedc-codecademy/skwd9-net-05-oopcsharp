using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            bool parsingResult1 = int.TryParse(Console.ReadLine(), out int num1);
            Console.Write("Enter another number: ");
            bool parsingResult2 = int.TryParse(Console.ReadLine(), out int num2);
            int larger;
            if (parsingResult1 && parsingResult2)
            {
                if (num1 >= num2)
                {
                    larger = num1;
                    Console.WriteLine("First is larger!");
                }
                else
                {
                    larger = num2;
                    Console.WriteLine("Second is larger!");
                }

                if (larger != 0)
                {
                    if (larger % 2 == 0)
                    {
                        Console.WriteLine("Number is Even!");
                    }
                    else if (larger % 2 != 0)
                    {
                        Console.WriteLine("Number is Odd!");
                    }
                }
                else
                {
                    Console.WriteLine("You entered Zero.Can not determine even/odd");
                }
            }
            else
            {
                Console.WriteLine("Some of the inputs is not an int");
            }

            Console.ReadLine();
        }
    }
}
