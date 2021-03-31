using System;

namespace RetroExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfIntegers = new int[5];
            int sum = 0;
            for (int i = 0; i < arrayOfIntegers.Length; i++)
            {
                Console.WriteLine("Enter index " + i);
                bool success = int.TryParse(Console.ReadLine(), out int number);
                if (!success)
                {
                    throw new Exception("Input can not be parsed");
                }
                arrayOfIntegers[i] = number;
            }
            foreach (int num in arrayOfIntegers) sum += num;
            Console.WriteLine("The result is: " + sum);
            Console.ReadLine();
        }
    }
}
