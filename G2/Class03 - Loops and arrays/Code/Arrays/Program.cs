using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //empty integer array with length 3
            int[] emptyIntegerArray = new int[3];
            emptyIntegerArray[0] = 5;
            emptyIntegerArray[1] = 7;
            emptyIntegerArray[2] = 33;

            Console.WriteLine(emptyIntegerArray[1]);
            // emptyIntegerArray[3] = 55; - error, out of index boundaries

            string[] stringsArray = { "Bob", "Paul", "Jane" };
            Console.WriteLine(stringsArray[1]);

            Console.WriteLine($"StringsArray length: {stringsArray.Length}");

           // double[] doublesArray = { 2, 33.3, 44.6, 7, true }; - mixed arrays are not allowed
           double[] doublesArray = { 2, 33.3, 44.6, 7, 68 };
            //doublesArray[5] = 55.9; - exception


            //RESIZE
            Array.Resize(ref doublesArray, 7);
            doublesArray[5] = 55.9;

            //INDEX OF
            int indexFound = Array.IndexOf(doublesArray, 44.6);
            Console.WriteLine("Index of 44.6:");
            Console.WriteLine(indexFound);

            int indexNotFound = Array.IndexOf(doublesArray, 5);
            Console.WriteLine("Index of 5:");
            Console.WriteLine(indexNotFound);

            //REVERSE
            Console.WriteLine("===Reverse===");
            Console.WriteLine(doublesArray[0]);
            Array.Reverse(doublesArray);
            Console.WriteLine(doublesArray[0]);


            string[] names = { "Bob", "Paul", "Jane" , "Marry", "Kate", "Sam"};
            //iterates each member - similar to for-of in JS
            foreach (string name in names)
            {
                Console.WriteLine(name);
                if (name == "Jane")
                    break;
            }
            Console.ReadLine();

        }
    }
}
