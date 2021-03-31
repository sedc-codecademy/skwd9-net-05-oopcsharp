using System;

namespace SEDC.CSharpOop.Class03.Excerscises
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Excersice 1
            Console.WriteLine("Enter a number:");
            int ex1input1 = int.Parse(Console.ReadLine());
            for (int i = 1; i <= ex1input1; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Enter another number:");
            int ex1input2 = int.Parse(Console.ReadLine());
            for (int i = ex1input2; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
            #endregion

            #region Excersice 2
            Console.WriteLine("Enter a number:");
            int ex2input1 = int.Parse(Console.ReadLine());
            for (int i = 2; i <= ex2input1; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("Enter another number:");
            int ex2input2 = int.Parse(Console.ReadLine());
            for (int i = 1; i <= ex2input2; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
            #endregion

            #region Excersice 3
            Console.WriteLine("Enter a number:");
            int ex3input = int.Parse(Console.ReadLine());
            for (int i = 1; i <= ex3input; i++)
            {
                if (i % 3 == 0 || i % 7 == 0)
                {
                    continue;
                }
                if (i == 100)
                {
                    Console.WriteLine("The limit is reached!");
                    break;
                }
                Console.WriteLine(i);
            }
            Console.ReadLine();
            #endregion

            Console.WriteLine("Hello World!");
        }
    }
}
