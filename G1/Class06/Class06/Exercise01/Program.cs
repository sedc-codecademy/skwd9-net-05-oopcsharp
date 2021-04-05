using System;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal number;

            while (true)
            {
                Console.WriteLine("Please enter a number:");
                string input = Console.ReadLine();

                bool success = decimal.TryParse(input, out number);

                if(success) break;
            }

            if (number >= 0)
            {
                Console.WriteLine("Positive");
            }
            else
            {
                Console.WriteLine("Negative");
            }

            if (number % 1 == 0)
            {
                Console.WriteLine("Integer");
                OddOrEven(int.Parse(number.ToString()));
            }
            else
            {
                Console.WriteLine("Decimal");

                string numberString = number.ToString();
                string lastNumberString = numberString.Substring(numberString.Length - 1, 1);
                int lastNumber = int.Parse(lastNumberString);
                OddOrEven(lastNumber);
            }
        }

        static void OddOrEven(int number)
        {

            if (number % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }
    }
}
