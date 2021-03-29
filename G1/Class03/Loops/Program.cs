using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ForLoop

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            //int i = 1;

            //for (; i <= 10;)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            for (; ; )
            {
                Console.WriteLine("If you want to stop with the execution, please enter X.");
                var input = Console.ReadLine();

                if (input == "X" || input == "x") break;
            }

            for (int i = 1; i <= 1000; i++)
            {
                if (i % 2 == 1) continue;

                Console.WriteLine(i);
            }

            for (int i = 2; i <= 1000; i += 2)
            {
                Console.WriteLine(i);
            }

            #endregion

            #region While

            int counter = 1;

            while (counter <= 10)
            {
                Console.WriteLine(counter);
                counter++;
            }

            while (true)
            {
                Console.WriteLine("Do you want to stop application? Write: y if you want to stop it.");
                string input = Console.ReadLine();

                if (input == "y" || input == "Y") break;
            }



            #endregion

            int newCounter = 0;

            do
            {
                Console.WriteLine(newCounter);
                newCounter++;
            } 
            while (newCounter >= 1 && newCounter <= 10);
        }
    }
}
