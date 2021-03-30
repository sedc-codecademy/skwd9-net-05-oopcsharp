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

            int counter = 0;
            while(counter < 10)
            {
                Console.WriteLine(counter);
                counter++;
            }

            bool isFourtyFour = false;
            int counter1 = 0;
            
            while(!isFourtyFour)
            {
                if(counter1 == 44)
                {
                    isFourtyFour = true;
                }

                counter1 += 4;
            }

            Console.WriteLine(counter1 + " " + isFourtyFour);

            #endregion


            Console.ReadLine();
        }
    }
}
