using System;

namespace ClassExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = "Hello from SEDC Codecademy 2021";
            Console.Write("Please enter the N value: ");
            int userInput = int.Parse(Console.ReadLine());

            string result = Substrings(inputString, userInput);
            Console.WriteLine(result);

            Console.ReadLine();
        }

        public static string Substrings(string inputString, int n) 
        {
            string substr = inputString.Substring(0, n);
            return $"This substring is: \"{substr}\", and the lengst of the substring is {substr.Length}";
        }
    }
}
