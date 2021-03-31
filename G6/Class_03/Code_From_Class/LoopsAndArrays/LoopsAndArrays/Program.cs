using System;

namespace LoopsAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------- Part 1 (Loops) -------------------------");

            #region For

            // For loop
            // 3 blocks ( 1. initialization, 2. condition, 3. increment/decrement )
            //for (int i = 1; i < 10; i++)
            //{
            //    Console.WriteLine($"Counter is: {i}");
            //}
            //Console.WriteLine("WE ARE DONE WITH FOR LOOP");

            //for (; ; )
            //{
            //    Console.WriteLine("We are in infinite loop!");
            //    Console.WriteLine("Press Q to exit");
            //    string quitInput = Console.ReadLine();
            //    // Extra: quitInput.toUpper() == "Q"
            //    if (quitInput == "Q" || quitInput == "q")
            //    {
            //        break;
            //    }
            //}

            #endregion

            #region While
            //int i = 1;
            //while (i < 10)
            //{
            //    Console.WriteLine($"Counter is: {i}");
            //    i++;
            //}

            //while (true)
            //{
            //    Console.WriteLine("We are in infinite loop!");
            //    Console.WriteLine("Press Q to exit");
            //    string quitInput = Console.ReadLine();
            //    // Extra: quitInput.toUpper() == "Q"
            //    if (quitInput == "Q" || quitInput == "q") break;
            //}

            // DO WHILE
            // int i = 1;
            //do
            //{
            //    Console.WriteLine($"Counter is: {i}");
            //    i++;
            //} while (i < 10);

            //int j = 10;
            //do
            //{
            //    Console.WriteLine($"Counter is: {j}");
            //    j++;
            //} while (j < 10);

            #endregion

            #region Break and Continue

            //string inputNumber = Console.ReadLine();
            //int convertedNumber = int.Parse(inputNumber);
            //Console.WriteLine("----------------------------------------------");
            //for (int i = 1; i <= convertedNumber; i++)
            //{
            //    if(i == 70)
            //    {
            //        break;
            //    } 
            //    Console.WriteLine(i);
            //}

            //}
            //for (int i = convertedNumber; i >= 0; i--)
            //{
            //    if (i % 2 != 0)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Exercises

            // 1
            //Console.WriteLine("Please enter number: ");
            //string input1 = Console.ReadLine();
            //int number1 = int.Parse(input1);
            //for (int i = 1; i < number1; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("------------------------------------------");
            //Console.WriteLine("Please enter another number: ");
            //string input2 = Console.ReadLine();
            //int number2 = int.Parse(input2);
            //for (int i = number2; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}

            // 2
            //Console.Write("Please enter number: ");
            //string input1 = Console.ReadLine();
            //int number1 = int.Parse(input1);
            //for (int i = 2; i <= number1; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.Write("Please enter another number: ");
            //string input2 = Console.ReadLine();
            //int number2 = int.Parse(input2);
            //for (int i = 1; i <= number2; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            #endregion

            Console.WriteLine("------------- Part 2 (Arrays) -------------------------");

            #region Arrays
            // First Approach
            //int[] numbers = new int[5];
            //numbers[0] = 20;
            //numbers[1] = 30;
            //numbers[2] = 40;
            //numbers[3] = 50;
            //numbers[4] = 60;

            // How we get a value from array by indexes
            // Console.WriteLine(numbers[2]);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            // Shorter approaches
            int[] numbers = new int[] { 20, 30, 20, 50, 60 };
            // int[] numbers1 = { 1, 2, 3, 4, 5 };
            //for (int i = 0; i < numbers1.Length; i++)
            //{
            //    Console.WriteLine(numbers1[i]);
            //}

            string[] names = new string[] { "John", "Bob", "Jane" };
            bool[] booleans = new bool[] { false, true, true, false };

            // Length
            // Console.WriteLine(numbers.Length);

            // Array methods

            // Reverse => reverts the array passed as argument

            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            // IndexOf => returns the index of element we are searching for
            // Console.WriteLine(Array.IndexOf(numbers, 20));

            // Resize => sets a new size to the specified array
            //Array.Resize(ref names, names.Length + 1);
            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine($"NAME: {names[i]}");
            //}

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            // Exercise5

            int[] numbersArray = new int[5];
            int sum = 0;
            for (int i = 0; i < numbersArray.Length; i++)
            {
                Console.Write("Please insert a number: ");
                int parsedUserInput = int.Parse(Console.ReadLine());
                numbersArray[i] = parsedUserInput;
                sum += numbersArray[i];
            }

            Console.WriteLine("SUM IS: " + sum);


            #endregion

            Console.ReadLine();
        }
    }
}
