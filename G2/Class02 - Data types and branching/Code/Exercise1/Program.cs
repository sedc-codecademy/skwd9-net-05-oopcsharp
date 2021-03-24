using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstInteger; // declaration
            firstInteger = 4; // initialization
            int secondInteger = 12;
            int result1 = firstInteger / secondInteger;
            Console.WriteLine("Exercise 1 int Result: " + result1);

            double firstDouble = 4;
            double secondDouble = 12;
            //the result is double with decimals because both operands are double
            double result2 = firstDouble / secondDouble;
            Console.WriteLine("Exercise 1 double Result: " + result2);
            Console.ReadLine();
        }
    }
}
