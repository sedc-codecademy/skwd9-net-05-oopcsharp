using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //for loop
            for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine(i + 1);

                    if (i == 5)
                    {
                        continue;
                    }

                    if (i == 8)
                    {
                        break;
                    }

                    Console.WriteLine("end of the itteration");
                    //more code
                }

            // while loop
            int counter = 0;
            while (counter < 10) 
            {
                Console.WriteLine(counter + 1);
                counter++;
            }

            // do-while loop
            do
            {
                Console.WriteLine("do-while loop executed once!");
            } 
            while (false);

            //foreach
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }




            Console.ReadLine();
        }
    }
}
