using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstString = "Hello";
            string secondString = "World";
            string result1 = firstString + " " + secondString; // Adding empty space to divide the strings
            Console.WriteLine("Exercise 2 strings Result:" + result1);
            Console.WriteLine($"{firstString} {secondString}");

            string firstStringNumber = "9";
            string secondStringNumber = "3";
            //it concatenates the strings
            string result2 = firstStringNumber + secondStringNumber;
            Console.WriteLine("Exercise 2 numbers Result:" + result2);


            Console.ReadLine();
        }
    }
}
