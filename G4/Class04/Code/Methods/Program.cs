using System;

namespace Methods
{
    class Program
    {
        // Method with no parameters and no return
        static void CheckDroid1()
        {
            Console.WriteLine("These aren't the droids you are looking for.");
            Console.ReadLine();
        }

        // Method with parameters and no return
        static void CheckDroid2(bool isJedi)
        {
            if (isJedi)
            {
                Console.WriteLine("These aren't the droids you are looking for.");
            }
            else
            {
                Console.WriteLine("Take the droids. It's fine.");
            }
            Console.ReadLine();
        }

        // Method with no parameters and return
        static string JediMindTrick()
        {
            string statement = "Another mind trick that will confuse you all.";
            return statement;
            // return "Another mind trick that will confuse you all.";
        }

        // Method with parameters and return
        static string CheckDroid3(bool isJedi)
        {
            //if (isJedi)
            //{
            //    return "These aren't the droids you are looking for.";
            //}
            //else
            //{
            //    return "Take the droids. It's fine.";
            //}
            // elegant way - please do this
            return isJedi ? "These aren't the droids you are looking for." : "Take the droids. It's fine.";
        }

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
            Console.WriteLine("Hello Methods!");

            //CheckDroid1();

            //CheckDroid2(false);

            string resultFromJediMindTrick = JediMindTrick();
            //Console.WriteLine(resultFromJediMindTrick);

            string resultFromCheckDroid3 = CheckDroid3(true);
            //Console.WriteLine(resultFromCheckDroid3);

            // Exercise 01
            Console.WriteLine("Enter an operation ( + or - ):");
            string operation = Console.ReadLine();
            if (operation != "+" && operation != "-")
            {
                Console.WriteLine("Sorry! Wrong input!");
            }
            else
            {
                Console.Write("Enter first number:");
                int number1 = int.Parse(Console.ReadLine());
                Console.Write("Enter second number:");
                int number2 = int.Parse(Console.ReadLine());
                if (operation == "+") Console.WriteLine(Sum(number1, number2));
                if (operation == "-") Console.WriteLine(Subtract(number1, number2));
            }
            Console.ReadLine();
        }
    }
}
