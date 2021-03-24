using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "First", surname = "Second";
            string fullName = name + surname;

            Console.WriteLine(fullName);
            Console.WriteLine(name + surname);

            string num1 = "9";
            string num2 = "3";

            string result = num1 + num2;
            Console.WriteLine(result);
        }
    }
}
