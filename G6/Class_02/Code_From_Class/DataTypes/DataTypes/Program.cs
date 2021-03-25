using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            #region dataTypes
            // declaration
            string firstName;
            // initialization
            firstName = "John";
            // decalration and initialization is allowed in same time
            string lastName = "Doe";

            // working with numbers
            int number = 10000;
            short smallNumber = 1000;
            long bigNumber = 1000000000000000000;
            ulong ultraLongNumber = 10000000000000000000;

            float floatNumber = 10.22222228f;
            double doubleNumber = 10.22222228;

            // working with strings
            // they must me double quoted
            string text = "This is some text. Continues.....";

            // character
            // they must be single quoted
            char singleCharacter = '@';

            // booleans 
            bool isValid = true;

            // DateTime

            DateTime date = new DateTime(2021, 3, 25);
            #endregion

            #region operators
            // sum of numbers (+)
            int firstNumber = 10;
            int secondNumber = 20;
            int sumOfTwoNumbers = firstNumber + secondNumber;

            // concatanation of strings
            string fName = "Bob";
            string lName = "Bobsky";
            string fullName = fName + " " + lName;

            // EXTRA:
            //string fullName = $"{fName} {lName}";

            int salary = 500;
            salary += 50;

            salary -= 100;

            // Logical Operators

            bool result = true && false;

            bool result1 = false || true;

            bool result2 = true ^ false;


            #endregion

            #region Exercises
            //Exercse 1

            double firstDoubleNumber = 10.50;
            double secondDoubleNumber = 5.30;
            double resultFromDivideTwoDoubleNumbers = firstDoubleNumber / secondDoubleNumber;

            int firstIntNumber = 100;
            int secondIntNumber = 35;
            int resultFromDivideTwoIntNumbers = firstIntNumber / secondIntNumber;

            // Console.WriteLine($"Result from dividing two double numbers: {resultFromDivideTwoDoubleNumbers}");
            // Console.WriteLine($"Result from dividing two int numbers: {resultFromDivideTwoIntNumbers}");
            
            // Exercise 2
            string car = "Honda";
            string model = "Civic";
            string carModel = car + model;

            string numberString1 = "9";
            string numberString2 = "3";
            string sumOfTwoNumberStrings = numberString1 + numberString2;

            // Console.WriteLine(carModel);
            // GetType() => method to get the type of the value stored in the variable
            // Console.WriteLine(sumOfTwoNumberStrings.GetType());

            // Exercise 3
            int someNumber = 22;
            string someString = "This is text";
            string res = someNumber + someString;
            // Console.WriteLine(res);

            //Exercise 4

            int credit = 102;
            int messageCost = 5;

            int messsagesThatCanBeSend = credit / messageCost;
            // Console.WriteLine($"With {credit} denars, you can send {messsagesThatCanBeSend} messages");

            Console.ReadLine();
            #endregion
        }
    }
}
