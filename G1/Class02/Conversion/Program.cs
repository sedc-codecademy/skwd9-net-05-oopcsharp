using System;

namespace Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberAsString = "10";

            int number1 = int.Parse(numberAsString);
            Console.WriteLine(number1);

            int number2 = Convert.ToInt32(numberAsString);
            Console.WriteLine(number2);
            
            bool successfulConversion = int.TryParse(numberAsString, out int number3);
            Console.WriteLine("Conversion is successful: " + successfulConversion);
            Console.WriteLine(number3);


            ////////////////
            string stringAsString = "R";

            //int result1 = int.Parse(stringAsString);
            //Console.WriteLine(result1);

            //int result2 = Convert.ToInt32(stringAsString);
            //Console.WriteLine(result2);

            bool successfulStringConversion = int.TryParse(stringAsString, out int result3);
            Console.WriteLine("Conversion is successful: " + successfulStringConversion);
            Console.WriteLine(result3);

            ////// Input from Console
            Console.WriteLine("Please enter something:");
            string input = Console.ReadLine();
            Console.WriteLine("You have entered: " + input);

            //Input a number and check if it is even or odd
            Console.WriteLine("Please enter a number:");
            string inputNumber = Console.ReadLine();

            bool successfulNumberConversion = int.TryParse(inputNumber, out int number);

            //if (successfulNumberConversion)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine("Number is even!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Number is odd");
            //    }

            //    Console.WriteLine(number % 2 == 0 ? "Number is even!" : "Number is odd");
            //}
            //else
            //{
            //    Console.WriteLine("Not a number!");
            //}

            if (!successfulNumberConversion)
            {
                Console.WriteLine("Not a number!");
            }
            else if (number % 2 == 0)
            {
                Console.WriteLine("Number is even!");
            }
            else
            {
                Console.WriteLine("Number is odd");
            }

            //if (!successfulNumberConversion)
            //    Console.WriteLine("Not a number!");
            //else if (number % 2 == 0)
            //    Console.WriteLine("Number is even!");
            //else
            //    Console.WriteLine("Number is odd");
        }
    }
}
