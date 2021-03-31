using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] emptyIntArray;
            //emptyIntArray = new int[10];

            // | | | |
            int[] emptyIntArray = new int[10];
            emptyIntArray[0] = 15;
            emptyIntArray[9] = 11;
            emptyIntArray[7] = 9;


            for (int i = 0; i < emptyIntArray.Length; i++)
            {
                //Console.WriteLine(emptyIntArray[i]);
                Console.Write(emptyIntArray[i]);

                if (i != emptyIntArray.Length - 1)
                {
                    Console.Write(", ");
                }
            }

            string[] names = new string[] {"Risto", "Adis", "Marko"};
            bool[] boolArray = new bool[] {true, false, false, false, true};
            char[] charArray = new char[] {'A', 'c', '7'};
            int[] number = new int[] {-10, 7, 15};

            //Array functions
            int indexFound = Array.IndexOf(number, 15);
            Console.WriteLine(indexFound);
            int indexNotFound = Array.IndexOf(number, 17);
            Console.WriteLine(indexNotFound);

            Array.Reverse(number);

            Console.WriteLine("Please enter a name");
            string inputName = Console.ReadLine();
            Array.Resize(ref names, 4);
            names[3] = inputName;

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            //multidimensional arrays
            // | | | | |
            // | | | | |
            // | | | | |
            int[,] twoDimensionalArray = new int[3, 4];
            twoDimensionalArray[0, 0] = 0;
            twoDimensionalArray[0, 1] = 1;
            twoDimensionalArray[0, 2] = 2;
            twoDimensionalArray[0, 3] = 3;
            twoDimensionalArray[1, 0] = 4;
            twoDimensionalArray[1, 1] = 5;
            twoDimensionalArray[1, 2] = 6;
            twoDimensionalArray[1, 3] = 7;
            twoDimensionalArray[2, 0] = 8;
            twoDimensionalArray[2, 1] = 9;
            twoDimensionalArray[2, 2] = 10;
            twoDimensionalArray[2, 3] = 11;

            //for(int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.WriteLine(twoDimensionalArray[j, i]);
            //    }
            //}

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(twoDimensionalArray[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
