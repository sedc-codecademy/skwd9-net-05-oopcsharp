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
        }
    }
}
