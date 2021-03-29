using System;

namespace Exercise05
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Vnesete broj:");
                string input = Console.ReadLine();

                bool validParse = int.TryParse(input, out int number);

                if (!validParse)
                {
                    i--;
                    continue;
                }

                numbers[i] = number;
            }

            int sum = 0;

            foreach (var number in numbers)
            {
                sum += number;
            }

            Console.WriteLine("Sum: " + sum);

            //int sum = 0;
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Vnesete broj:");
            //    string input = Console.ReadLine();

            //    bool validParse = int.TryParse(input, out int number);

            //    if (!validParse)
            //    {
            //        i--;
            //        continue;
            //    }

            //    sum += number;
            //}

            //Console.WriteLine("Sum: " + sum);
        }
    }
}
