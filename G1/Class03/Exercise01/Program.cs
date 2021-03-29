using System;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            bool validParse = int.TryParse(input1, out int number1);

            if (!validParse)
            {
                Console.WriteLine("Error");
                return;
            }

            Console.WriteLine("------- Print ---------");

            for (int i = 1; i <= number1; i++)
            {
                Console.WriteLine(i);
            }

            string input2 = Console.ReadLine();
            bool validParse2 = int.TryParse(input2, out int number2);

            if (!validParse2)
            {
                Console.WriteLine("Error");
                return;
            }
            Console.WriteLine("------- Print ---------");

            for (int i = number2; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
