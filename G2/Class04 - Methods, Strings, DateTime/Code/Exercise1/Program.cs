using System;

namespace Exercise1
{
    class Program
    {
        static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
        static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter an operation ( + or - ):");
            string operation = Console.ReadLine();
            if (operation != "+" && operation != "-")
            {
                Console.WriteLine("Sorry! Wrong input!");
                return;
            }
            Console.Write("Enter first number:");
            bool res = int.TryParse(Console.ReadLine(), out int firstNumber);
            Console.Write("Enter second number:");
            res = int.TryParse(Console.ReadLine(), out int secondNumber);
            if (operation == "+") Console.WriteLine(Sum(firstNumber, secondNumber));
            if (operation == "-") Console.WriteLine(Subtract(firstNumber, secondNumber));

            Console.ReadLine();
        }
    }
}
