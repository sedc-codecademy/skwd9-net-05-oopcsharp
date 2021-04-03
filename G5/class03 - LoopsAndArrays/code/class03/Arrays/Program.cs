using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // empty array with 5 elements
            int[] numbers = new int[5];
            numbers[0] = 5;
            numbers[1] = 15;
            //numbers[5] = 100;

            double[] decimalNmbers = new double[] { 2.3, 4.4, 5, 1.2 };
            decimalNmbers[1] = 100.25;
            //decimalNmbers[4] = 1000.1;

            string[] names = new string[] { "Viktor", "Angela", "Igor", "Petar" };

            bool[] boolArray = { true, false, false, true };

            Console.WriteLine(decimalNmbers[1]);

            //Array Properties

            //.Length
            int[] integers = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine(integers.Length);

            //Array Methods

            //IndexOf
            int index = Array.IndexOf(names, "Ana");
            Console.WriteLine(index);

            //Reverse
            Array.Reverse(names);

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            //Resize
            int[] integers2 = new int[5];

            //integers2[5] = 100;

            Array.Resize(ref integers2, 7);
            integers2[5] = 100;
            Console.WriteLine(integers2[5]);

            Console.WriteLine("=======================");

            int numberOne = 1;
            int numberTwo = Mtd(ref numberOne);

            Console.WriteLine(numberOne);
            Console.WriteLine(numberTwo);

            numberTwo = 10;

            Console.WriteLine(numberOne);
            Console.WriteLine(numberTwo);

            Console.WriteLine("=======================");

            int[] integers3 = { 1, 2, 3, 4, 5, 6 };

            Array.Resize(ref integers3, 4);
            //Console.WriteLine(integers3[5]);
        }

        static int Mtd(ref int refArguemnt)
        {
            return refArguemnt += 100;
        }

        static int Mtd2(int number)
        {
            return number += 100;
        }
    }
}
