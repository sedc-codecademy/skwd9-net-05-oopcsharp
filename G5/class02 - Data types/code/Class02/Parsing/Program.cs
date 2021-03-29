using System;

namespace Parsing
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Write your name: ");
            //string name = Console.ReadLine();
            //Console.WriteLine("Hello there, " + name);

            Console.Write("Enter first number: ");
            string number1 = Console.ReadLine();

            Console.Write("Enter second number: ");
            string number2 = Console.ReadLine();

            int result = int.Parse(number1) + int.Parse(number2);
            Console.WriteLine(result);

            //string doubleVarString = "10.45";
            //double doubleVar = double.Parse(doubleVarString);
            //Console.WriteLine(doubleVar);

            //string intVarString = "100";

            //int convertInt = Convert.ToInt32(intVarString);

            int age;
            Console.Write("Please enter your age: ");
            string ageInput = Console.ReadLine();

            bool ageCheck = int.TryParse(ageInput, out age);

            if (ageCheck)
            {
                Console.WriteLine("User age is: " + age);
            }
            else 
            {
                Console.WriteLine("Wrong input!!!");
            }

            Console.WriteLine(age);
            Console.WriteLine(ageCheck);

            Console.ReadLine();
        }
    }
}
