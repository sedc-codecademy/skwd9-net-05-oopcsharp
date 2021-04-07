using System;

namespace NumberStats
{
    class Program
    {
        static void Main(string[] args)
        {
            //while (UserInterface())
            //Console.ReadLine();

            string text = "John Doe new  n           nnn na J";
            char[] chars = text.ToCharArray();

            // EXTRA FROM QUESTIONS

            // NESTED FORS

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    Console.WriteLine($"MAIN FOR: {i}");
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine($"INSIDE NESTED FOR: {j}");
            //    }
            //}

            //int maxOccurences = 1;
            //char characterWithMaxOcc = chars[0];
            //for (int i = 0; i < chars.Length; i++)
            //{
            //    int temporaryOccurences = 1;
            //    if (chars[i] == ' ')
            //    {
            //        continue;
            //    }
            //    for (int j = i + 1; j < chars.Length; j++)
            //    {
            //        if (chars[i] == chars[j])
            //        {
            //            temporaryOccurences++;

            //        }
            //    }
            //    if (temporaryOccurences > maxOccurences)
            //    {
            //        maxOccurences = temporaryOccurences;
            //        characterWithMaxOcc = chars[i];
            //    }
            //}
            //Console.WriteLine(characterWithMaxOcc);
            //Console.WriteLine(maxOccurences);
            Console.ReadLine();
        }
        static bool UserInterface()
        {
            Console.Write("Please enter a number: ");
            bool isNumber = double.TryParse(Console.ReadLine(), out double number);
            if (!isNumber)
            {
                Console.WriteLine("You inserted invalid number! Please ty again!");
                return true;
            }
            NumberStats(number);
            Console.Write("Press any key to try again or Q to quit.");
            string answer = Console.ReadLine();
            if (answer.Equals("Q", StringComparison.InvariantCultureIgnoreCase))
            {
                return false;
            }
            return true;
        }

        static void NumberStats(double number)
        {
            bool isNegative = number < 0;
            bool isEven = number % 2 == 0;
            bool isDecimal = Math.Abs(number) % 1 > 0;
            string numberType = isDecimal ? "Decimal" : "Ingeter";
            Console.WriteLine($"Stats for number: {number}");
            Console.WriteLine($"{number} is negative: {isNegative}");
            Console.WriteLine($"{number} is Even: {isEven}");
            Console.WriteLine($"{number} is of type {numberType}");
        }
    }
}
