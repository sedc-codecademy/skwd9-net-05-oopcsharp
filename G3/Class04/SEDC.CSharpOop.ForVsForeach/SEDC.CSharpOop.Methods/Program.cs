using System;

namespace SEDC.CSharpOop.Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //string greeting = GetG3Greeting();
            //bool isNameLongerThen2Chars = ValidateName("Da");
            //if (isNameLongerThen2Chars)
            //{
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    Console.WriteLine("The name is valid");
            //}
            //else
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("The inserted name is not valid");
            //}
            //Console.ResetColor();
            //string userInput = Console.ReadLine();
            //bool isNumber = int.TryParse(userInput, out int number);
            //if (isNumber)
            //{
            //    string[] methodOutput = GetAllNames(number);
            //    foreach (var name in methodOutput)
            //    {
            //        Console.Write(name + " ");
            //    }
            //}
            Console.WriteLine("Please enter operator");
            string insertOperator = Console.ReadLine();
            Console.WriteLine("Please enter first number");
            string firstNumInput = Console.ReadLine();
            Console.WriteLine("Please enter second number");
            string secondNumberInput = Console.ReadLine();
            bool isFirstNumberValid = int.TryParse(firstNumInput, out int firstNumber);
            bool isSecondNumberValid = int.TryParse(secondNumberInput, out int secondNumber);
            if(insertOperator == "+")
            {
                if(isFirstNumberValid && isSecondNumberValid)
                {
                    int sumResult = Sum(firstNumber, secondNumber);
                    Console.WriteLine(sumResult);
                }
                else
                {
                    Console.WriteLine("The input numbers were not valid");
                }
            }else if(insertOperator == "-")
            {
                if(isFirstNumberValid && isSecondNumberValid)
                {
                    int substractResult = Substract(firstNumber, secondNumber);
                    Console.WriteLine("The substraction result is " + substractResult);
                }
                else
                {
                    Console.WriteLine("The numbers were not valid");
                }
                
            }
            else
            {
                Console.WriteLine("The operator is not valid");
            }

            Console.ReadLine();
        }
        //Method that returns a string
        static string GetG3Greeting()
        {
            return "Hello G3 from C# basic";
        }
        //Method that returnes boolean
        static bool ValidateName(string firstName)
        {
            if(firstName.Length > 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Method that returns an array
        static string[] GetAllNames(int number)
        {
            string[] lastNames = { "Stojanovski", "Stevkovski", "Bobsky", "Jillsky" };
            string[] firstNames = { "Damjan", "Trajan", "Bob", "Jill" };

            if(number == 1)
            {
                return lastNames;
            }
            else if(number == 2)
            {
                return firstNames;
            }
            else
            {
                return new string[] { };
            }
        }

        //Exercise 1
        static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        static int Substract(int num1, int num2)
        {
            return num1 - num2;
        }
        //function getUsersByFirstName(let firstName){
        // let users = _dbUsers.users.filter(x => x.firstname === firstName);
        // return users;
        //}
    }
}
