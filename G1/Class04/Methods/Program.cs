using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintHelloWorldStatic();

            (new Program()).PrintHelloWorld();

            //int[] numbers = new int[] {1, 7, 9, 10, 11, 12, 17, 18, 20};
            //int[] evenNumbers = new int[4] { 2, 4, 6, 8 };
            //int[] oddNumbers = new int[5] { 1, 3, 4, 7, 9 };

            //PrintIntArray(numbers);
            //PrintIntArray(evenNumbers);
            //PrintIntArray(oddNumbers);

            int[] numbers = new int[] { 1, 7, 9, 10, 11, 12, 17, 18, 20 };

            PrintIntArray(numbers);
            int[] evenNumbers = FilterEvenNumbers(numbers);
            PrintIntArray(evenNumbers);
            //PrintIntArray(FilterEvenNumbers(numbers));

            Console.WriteLine(FullName("Risto", "Panchevski"));
            Console.WriteLine(FullName("Risto", "Panchevski", 31));
        }

        static void PrintHelloWorldStatic()
        {
            Console.WriteLine("Hello World! -> Static");
        }

        void PrintHelloWorld()
        {
            Console.WriteLine("Hello World! -> Non Static");
        }

        static void PrintIntArray(int[] array)
        {
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static int[] FilterEvenNumbers(int[] array)
        {
            int[] evenNumbers = new int[0];

            foreach (int item in array)
            {
                if (item % 2 == 0)
                {
                    Array.Resize(ref evenNumbers, evenNumbers.Length + 1);
                    evenNumbers[evenNumbers.Length - 1] = item;
                }
            }

            return evenNumbers;
        }

        static string FullName(string firstName, string lastName, int age = 0)
        {
            string ageString = "/";

            if (age > 0)
            {
                ageString = age.ToString();
            }
            string fullName = firstName + " " + lastName + " (" + ageString + ")";
            return fullName;
        }
    }
}
