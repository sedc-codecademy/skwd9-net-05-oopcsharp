using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int ourInteger = 9;
            string ourString = "Code";
            bool ourBool = true;
            string result1 = ourInteger + ourString;
            string result2 = ourBool + ourString;
            Console.WriteLine("Exercise 3 Result 1 :" + result1);
            Console.WriteLine("Exercise 3 Result 2 :" + result2);
            Console.ReadLine();
        }
    }
}
