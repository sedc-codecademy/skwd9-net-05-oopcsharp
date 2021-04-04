using System;

namespace SEDC.CSharpOop.ForVsForeach.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            numbers[0] = 3;
            numbers[1] = 5;
            numbers[2] = 7;
            numbers[3] = 9;
            numbers[4] = 10;

            //using for loop
            // We use for when we need the indexes of the elements in the array
            //for(int counter = 0; counter < numbers.Length; counter++)
            //{
            //    Console.Write(numbers[counter]+ " ");
            //}
            // Foreach works with collections and we use it when we dont need
            // indexes.
            //foreach(int number in numbers)
            //{
            //    Console.WriteLine(number + " ");
            //}

            //string[] words = { "Dog", "Cat", "Bob", "Jill" };
            //foreach(string word in words)
            //{
            //    Console.WriteLine(word);
            //}


            //Task get the sum of 5 numbers squared.
            //int[] fiveNumsArray = { 2, 3, 5, 6, 8 };
            //int sum = 0;
            //foreach(int element in fiveNumsArray)
            //{
            //    sum = sum + (element * element);
            //}

            //Console.WriteLine("The result of the squared sums of the numbers in the array is " + sum);

            ////Array of arrays
            //int[][] arrayOfIntegerArrays = new int[3][];
            //arrayOfIntegerArrays[0] = new int[] { 4, 7 };
            //arrayOfIntegerArrays[1] = new int[] { 9, 1 };
            //arrayOfIntegerArrays[2] = new int[] { 11, 17 };

            //foreach(int[] intArray  in arrayOfIntegerArrays)
            //{
            //    foreach(int number in intArray)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}
            //Task 5
            int[] numbersArray = new int[5];
            int sum = 0;
            for(int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Please enter a number");
                string numberInput = Console.ReadLine();
                bool isValidNumber = int.TryParse(numberInput, out int number);
                if (isValidNumber)
                {
                    numbersArray[i - 1] = number;
                    Console.WriteLine($"The {i} number that was added in the array is: {number}");
                    sum += number;
                    continue;
                }
                Console.WriteLine("The added input was not valid number. The program will count it as 0.");
            }
            Console.WriteLine($"The sum of the added numbers is {sum}");
            //Task 6
            //string[] names = new string[2];
            //names[0] = "Damjan";
            //names[1] = "Trajan";
            //string newName;
            //string userInput;
            //do
            //{
            //    Console.WriteLine("Please enter a name");
            //    newName = Console.ReadLine();
            //    Array.Resize(ref names, names.Length + 1);
            //    names[names.Length - 1] = newName;
            //    Console.WriteLine("You have entered the name " + newName + " in the array");
            //    Console.WriteLine("Would you like to enter an other name?");
            //    userInput = Console.ReadLine();
            //    if (userInput != "y" && userInput != "Y")
            //    {
            //        Console.WriteLine("The names in the array are ");
            //        foreach (var name in names)
            //        {
            //            Console.WriteLine(name);
            //        }
            //    }
            //} while (userInput == "y" || userInput == "Y");
            Console.Read();
        }
    }
}
