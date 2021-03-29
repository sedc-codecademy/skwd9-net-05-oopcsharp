using System;

namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool validParse = int.TryParse(input, out int number);

            if (!validParse)
            {
                Console.WriteLine("Wrong input");
                return;
            }

            int counter = 0;
            int i = 1;

            while (i <= number && counter < 100)
            {
                if (i % 3 != 0 && i % 7 != 0)
                {
                    Console.WriteLine(i);
                    counter++;
                }

                i++;
            }
            
            if (counter == 100)
            {
                Console.WriteLine("The limit is reached and stop counting");
            }
        }
    }
}
