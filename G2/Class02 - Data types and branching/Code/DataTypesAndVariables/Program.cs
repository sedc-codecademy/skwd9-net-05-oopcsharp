using System;

namespace DataTypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            int ourFirstInteger; //declaration
            ourFirstInteger = 5; //initialization
            int ourSecondInteger = 10; //declaration and initialization

            Console.WriteLine("Our first integer: ");
            Console.WriteLine(ourFirstInteger);
            Console.WriteLine("Our second integer: ");
            Console.WriteLine(ourSecondInteger);
           // Console.ReadLine();

           float ourFirstFloat = 2.3F;
           Console.WriteLine("Our first float: ");
           Console.WriteLine(ourFirstFloat);

           double ourFirstDouble = 2.5;
           Console.WriteLine("Our first double: ");
           Console.WriteLine(ourFirstDouble);

           long longInteger = 232322323232323;
           Console.WriteLine("Our first long: ");
           Console.WriteLine(longInteger);

           bool ourFirstBool = true;
           char ourFirstChar = 'a'; //single quotes
           Console.WriteLine("Our first char: ");
           Console.WriteLine(ourFirstChar);

           string message = "Hello World from SEDC again!"; //double quotes
           Console.WriteLine(message);

          // ourFirstBool = 10; value must be of same type
          ourFirstBool = false;

          int sum = ourFirstInteger + ourSecondInteger;
          //the result must be saved in double, because one of the operands is double (with higher precision)
          double sumOfDifferentNumbers = ourFirstInteger + ourFirstDouble;
          Console.WriteLine("sum: ");
          Console.WriteLine(sum);

          sum++;
          Console.WriteLine("sum: ");
          Console.WriteLine(sum);

          double divisionResult = ourFirstInteger / (double)ourSecondInteger;
          Console.WriteLine("Division: ");
          Console.WriteLine(divisionResult);

          string firstName = "Petko";
          string lastName = "Stankovski";

          Console.WriteLine(firstName + " " +lastName); //concatenation
          Console.WriteLine($"Hello from: {firstName} {lastName}"); //interpolation

            Console.ReadLine();
        }
    }
}
