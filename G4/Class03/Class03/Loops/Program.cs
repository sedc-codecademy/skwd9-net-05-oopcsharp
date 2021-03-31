using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Loops!");

            #region For Loop
            //// simple for loop
            //for(int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("Counter is:" + i);
            //}

            //// infinite loop with for
            //for(; ; )
            //{
            //    Console.WriteLine("This will go on forever... Unless you enter X");
            //    string input = Console.ReadLine();
            //    if (input == "X" || input == "x") break;
            //}
            #endregion

            #region While Loop
            //// simple while loop
            //int whileCounter = 1;

            //while(whileCounter <= 10)
            //{
            //    Console.WriteLine("Counter is: " + whileCounter);

            //    whileCounter += 1;
            //}

            //// infinite loop with while
            //while (true)
            //{
            //    Console.WriteLine("This will go on forever... Unless you enter X");
            //    string whileInput = Console.ReadLine();
            //    if (whileInput == "X" || whileInput == "x") break;
            //}
            #endregion

            #region Do While Loop
            //// simple do while loop
            //int doWhileCounter = 1;

            //do
            //{
            //    Console.WriteLine("Counter is: " + doWhileCounter);
            //    doWhileCounter++;
            //}
            //while (doWhileCounter <= 10);

            //// weird do while loop
            //do
            //{
            //    Console.WriteLine("This shouldn't be printed?!?!!!");
            //}
            //while (false);
            #endregion

            #region Break & Continue
            //// loop with break
            //Console.WriteLine(" ------- Break -----------");
            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i == 3) break;
            //    Console.WriteLine("Counter is:" + i);
            //}
            //// break exits the for loop immediately

            //// loop with continue
            //Console.WriteLine(" ------- Continue -----------");
            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i == 3) continue;
            //    Console.WriteLine("Counter is:" + i);
            //}
            //// continue exits the current sycle and continues to the next ones
            #endregion

            #region Exercises
            //// Exercise 01
            //Console.WriteLine("Enter a number:");
            //int exercise1Input1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Output");
            //for (int i = 1; i <= exercise1Input1; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("--------------------------");

            //Console.WriteLine("Enter another number:");
            //int exercise1Input2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Output");
            //for (int i = exercise1Input2; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //// Exercise 02
            //Console.WriteLine("Enter a number:");
            //int exercise2Input = int.Parse(Console.ReadLine());
            //Console.WriteLine("Even numbers");
            //for (int i = 2; i <= exercise2Input; i += 2)
            //{
            //    Console.WriteLine(i);
            //}

            //// option with modulus

            //Console.WriteLine("Odd numbers");
            //for (int i = 1; i <= exercise2Input; i++)
            //{
            //    if(i % 2 != 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            // Exercise 03
            Console.WriteLine("Enter a number:");
            int exercise3Input = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------");

            for (int i = 1; i < exercise3Input; i++)
            {
                if (i % 3 == 0 || i % 7 == 0) continue;
                if(i == 100)
                {
                    Console.WriteLine("The limit is reached!");
                    break;
                }
                Console.WriteLine(i);
            }
            #endregion
            Console.ReadLine();
        }
    }
}
