using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello G4!");
            #region DataTypes
            // declaration
            int integerVariable1 = 0;
            // initialization
            integerVariable1 = 5;
            // declaration & initialization
            int integerVariable2 = 15;

            float floatVariable = 23.4F;
            double doubleVariable = 84839674.257;

            // strings have to be in double quotes
            string name = "Kristina";
            name = "Panche";
            char operatorVariable = '*';

            bool boolVariable = false;
            long longerInteger = 7326525723758475843;

            Console.WriteLine("---------- DataTypes -----------");
            Console.WriteLine(integerVariable1);
            Console.WriteLine(integerVariable2);
            Console.WriteLine(floatVariable);
            Console.WriteLine(doubleVariable);
            Console.WriteLine(name);
            Console.WriteLine(operatorVariable);
            Console.WriteLine(boolVariable);
            Console.WriteLine(longerInteger);
            #endregion

            #region Operators

            Console.WriteLine("---------- Operators -----------");

            // + operator sums two sides if they're numbers
            int sumOfTwoNumbers = 7 + 8;
            Console.WriteLine(sumOfTwoNumbers);
            // + operator concatenates two strings
            Console.WriteLine("5" + "4");

            int modulusOperator = 10 % 3;
            // it gives you an error if you try this 10 % "3"
            Console.WriteLine(modulusOperator);

            sumOfTwoNumbers += 10;
            //sumOfTwoNumbers = sumOfTwoNumbers + 10
            Console.WriteLine("Sum again: " + sumOfTwoNumbers);

            Console.WriteLine(true || false); // true
            Console.WriteLine(false ^ true); // true XOR

            // asigning new values with logical operators
            bool myBooleanVariable = true;
            myBooleanVariable &= false;
            // myBooleanVariable = myBooleanVariable && false
            Console.WriteLine(myBooleanVariable); // false

            int someNumber = 15;
            //someNumber = "Pane"; //you cannot change the type, even with VAR
            Console.WriteLine("===========================");
            #endregion

            #region Exercises
            Console.WriteLine("---------- Exercises -----------");
            // Exercise 01

            double firstDouble = 445432.25;
            double secondDouble = 65.28;
            double divisionDouble = firstDouble / secondDouble;

            int firstInteger = 345;
            int secondInteger = 87;
            int divisionInteger = firstInteger / secondInteger;

            Console.WriteLine(divisionDouble);
            Console.WriteLine(divisionInteger);
            Console.WriteLine("===========================");

            // Exercise 02

            string bookString01 = "Zoki";
            string bookString02 = "Vaksajns";
            string sumBooksString = bookString01 + " " + bookString02;
            Console.WriteLine(sumBooksString);

            string numString01 = "9";
            string numString02 = "3";
            string sumNumString = numString01 + numString02;
            // you can check the type of the variable with GetType() method
            Console.WriteLine(sumNumString.GetType());

            // Exercise 03
            string randomString = "Random number";
            int randomNumber = 42;
            string resultRandom = randomString + randomNumber;
            Console.WriteLine(resultRandom);

            // Exercise 04
            int phoneCredit = 102;
            int priceMessage = 5;
            int howManyMessages = phoneCredit / priceMessage;
            Console.WriteLine("I can send " + howManyMessages + " messages.");
            #endregion

            Console.ReadLine();
        }
    }
}
