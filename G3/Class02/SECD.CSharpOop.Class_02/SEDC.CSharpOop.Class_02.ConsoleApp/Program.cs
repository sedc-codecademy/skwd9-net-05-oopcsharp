using System;

namespace SEDC.CSharpOop.Class_02.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Integers declaration
            // Integer declaration
            int age;
            //Variable initialization
            age = 28;

            //Console.WriteLine(age);
            short smallNumber = 37;
            //Console.WriteLine(smallNumber);

            // Biggest number data-type
            long bigNumber = 8690489809489045;
            // We can store smaller data-type in bigger but not the other way around
            //smallNumber = bigNumber;
            bigNumber = smallNumber;
            //2. Decimals data-types
            float floatingNumber = 3.56F;
            // Declaring double
            double doubleNumber = 5.789;
            // Declaring decimal
            decimal decimalType = 7.9056M;

            //Char as data type
            // When we declare a char we must use single quotes
            char userChoise = 'Y';

            // Declaring a boolean
            bool isOngoing = true;
            // Declaring string
            string title = "Hello G3 we are learning about data types.";

            // object type
            object myObj = new object();

            //Date time is data type for working with date in C#
            DateTime currentTime = DateTime.Now;
            DateTime date = new DateTime();

            Console.WriteLine(currentTime);
            Console.ReadLine();
        }
    }
}
