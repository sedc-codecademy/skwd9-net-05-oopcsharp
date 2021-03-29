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
        }
    }
}
