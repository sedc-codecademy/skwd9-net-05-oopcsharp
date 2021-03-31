using System;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an operation (+,/,-,*)");
            string operation = Console.ReadLine();

            Console.WriteLine("Enter the first number:");
            string firstNumberString = Console.ReadLine();

            int firstNumber;
            bool successFirstParse = int.TryParse(firstNumberString, out firstNumber);

            if (!successFirstParse)
            {
                Console.WriteLine("Wrong input for the first number");
                return;
            }

            Console.WriteLine("Enter the second number:");
            string secondNumberString = Console.ReadLine();

            int secondNumber;
            bool successSecondParse = int.TryParse(secondNumberString, out secondNumber);

            if (!successSecondParse)
            {
                Console.WriteLine("Wrong input for the second number");
                return;
            }

            if (operation == "/" && secondNumber == 0)
            {
                Console.WriteLine("For operation /, second number can not be 0");
                return;
            }

            switch (operation)
            {
                case "+":
                    Console.WriteLine("The result is: " + Sum(firstNumber, secondNumber));
                    break;
                case "-":
                    Console.WriteLine("The result is: " + Subtract(firstNumber, secondNumber));
                    break;
                case "*":
                    Console.WriteLine("The result is: " + Multiply(firstNumber, secondNumber));
                    break;
                case "/":
                    Console.WriteLine("The result is: " + Divide(firstNumber, secondNumber));
                    break;
                default:
                    Console.WriteLine("Wrong operation");
                    break;
            }
        }

        static int Sum(int a, int b)
        {
            return a + b;
        }

        static int Subtract(int a, int b)
        {
            return a - b;
        }

        static int Multiply(int a, int b)
        {
            return a * b;
        }

        static decimal Divide(int a, int b)
        {
            decimal c = Convert.ToDecimal(b);
            return a / c;
        }
    }
}
