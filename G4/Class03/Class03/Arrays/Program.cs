using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Arrays!");
            Console.WriteLine("------------- Array Intro -----------------");
            #region Arrays intro
            int[] emptyIntegerArray = new int[3];
            emptyIntegerArray[0] = 10;
            emptyIntegerArray[1] = 20;
            emptyIntegerArray[2] = 30;
            //Console.WriteLine(emptyIntegerArray);

            // read element in an array
            Console.WriteLine(emptyIntegerArray[0]);
            // set new value to an exisiting element in an array
            emptyIntegerArray[0] = 100;
            Console.WriteLine(emptyIntegerArray[0]);

            // try to set 4th element in an array
            //emptyIntegerArray[3] = 40;
            // throws an execption

            // shorter way of declaring an array --- hooray!!!
            int[] shorterWayIntegerArray = new int[]{ 2, 4, 6, 8 };
            int[] anotherEvenShorterArray = { 1, 3, 5, 7 };

            string[] stringArray = new string[]
            {
                "Kristina",
                "Panche"
            };
            Console.WriteLine(stringArray[1]);

            bool[] boolArray = new bool[]
            {
                false,
                true,
                true,
                false
            };

            char[] charArray = new char[]
            {
                '+',
                '-',
                '*',
                '/'
            };
            #endregion

            #region Array Methods
            int[] intArray = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("------------- Array Methods -----------------");

            // length
            Console.WriteLine(intArray.Length);

            // Array.Reverse
            //Array.Reverse(intArray);
            Console.WriteLine("First element after reverse is : " + intArray[0]);

            // Array.IndexOf
            int indexFound = Array.IndexOf(intArray, 3);
            Console.WriteLine("Index of found element is : " + indexFound);

            int indexNotFound = Array.IndexOf(intArray, 100);
            Console.WriteLine("Not found element index " + indexNotFound);

            // Array.Resize
            // to change length of an array
            // first parameter is the name of the array eq. ref myArray, the second is the new size/length we would like the array to have
            Array.Resize(ref intArray, 6);
            intArray[5] = 6;
            Console.WriteLine("New length: " + intArray.Length);
            Console.WriteLine("Last element is : " + intArray[intArray.Length - 1]);
            #endregion

            #region Foreach
            // foreach works only with arrays and loops each element in the array
            string[] students = new string[]
            {
                "Ceca",
                "Gjorgje",
                "Gligor",
                "Hristijan",
                "Jana",
                "Marta"
            };

            foreach (string item in students)
            {
                Console.WriteLine(item);
            }

            //for (int i = 0; i < students.Length; i++)
            //{
            //    Console.WriteLine(students[i]);
            //}
            #endregion

            #region Exercises
            // Exercise 01 
            int[,] nestedArray = new int[2,2]
            {
                { 1, 2 },
                { 3, 4 }
            };
            Console.WriteLine(nestedArray[0,0]);

            // Exercise 02
            int[] userArray = new int[5];
            int sumNumbers = 0;

            for (int i = 0; i < userArray.Length; i++)
            {
                Console.WriteLine("Enter number: ");
                userArray[i] = int.Parse(Console.ReadLine());
                sumNumbers += userArray[i];
            }

            Console.WriteLine("Sum of all numbers is " + sumNumbers);
            #endregion
            Console.ReadLine();
        }
    }
}
