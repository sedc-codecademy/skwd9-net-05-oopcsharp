using System;

namespace SEDC.CSharp.Class03.Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            #region FOR
            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for(int i = 0; i <= 100; i++)
            //{
            //    if(i % 2 != 0)
            //    {
            //        continue;
            //    }

            //    // -----
            //    if(i == 78) // if we have 77 here it will never enter into this if clause
            //    {
            //        break;
            //    }
            //    // -----
            //    Console.WriteLine("Is even " + i);
            //    // 100 lines of code
            //}
            #endregion

            #region WHILE

            //int counter = 0;
            //while(counter < 10)
            //{
            //    Console.WriteLine(counter);
            //    counter++;
            //}

            //bool isFourtyFour = false;
            //int counter1 = 0;

            //while(!isFourtyFour)
            //{
            //    if(counter1 == 44)
            //    {
            //        isFourtyFour = true;
            //    }

            //    counter1 += 4;
            //}

            //Console.WriteLine(counter1 + " " + isFourtyFour);

            //int counter2 = 0;
            //while(counter2 <= 100)
            //{
            //    counter2++;
            //    if (counter2 % 2 != 0)
            //    {
            //        continue;
            //    }

            //    if(counter2 == 78)
            //    {
            //        break;
            //    }

            //    Console.WriteLine("The number is even " + counter2);
            //}

            #endregion

            #region DO-WHILE

            //int counter5 = 0;
            //do
            //{
            //    Console.WriteLine(counter5);
            //    counter5++;
            //} while (counter5 < 10);

            //do
            //{
            //    Console.WriteLine("This will be executed once!");
            //} while (false);


            #endregion

            #region Loops

            // infinite loop
            //for(; ; )
            //{
            //    Console.WriteLine("Enter x to end");
            //    string input = Console.ReadLine();
            //    if(input == "x" || input == "X")
            //    {
            //        break;
            //    }
            //}
            //Console.WriteLine("End of infinite for loop");

            //while(true)
            //{
            //    Console.WriteLine("Enter q to end");
            //    string input = Console.ReadLine();
            //    if (input == "q" || input == "Q")
            //    {
            //        break;
            //    }
            //}
            //Console.WriteLine("End of infinite while loop");

            // get valid input from user
            Console.WriteLine("Please enter a number");
            int parsednumber = 0;
            while (!int.TryParse(Console.ReadLine(), out parsednumber))
            {
                Console.WriteLine("Please enter valid input!");
            }

            Console.WriteLine(parsednumber);
            bool isValidInput = false;
            int pasrsedNUMBER = 0;
            while (!isValidInput)
            {
                string input123 = Console.ReadLine();
                isValidInput = int.TryParse(input123, out pasrsedNUMBER);
            }
            
            #endregion


            Console.ReadLine();
        }
    }
}
