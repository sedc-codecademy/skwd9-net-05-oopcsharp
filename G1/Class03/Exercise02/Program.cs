using System;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            bool validParse = int.TryParse(input1, out int number1);

            for (int i = 2; i <= number1; i += 2)
            {
                Console.WriteLine(i);
            }

            string input2 = Console.ReadLine();
            bool validParse2 = int.TryParse(input2, out int number2);

            for (int i = 1; i <= number2; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
