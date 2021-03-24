using System;

namespace DataEntryAndConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name!");
            string name = Console.ReadLine();
            Console.WriteLine("Hello "+ name);
            Console.WriteLine($"Hello again {name}");
         

            //int number = Console.ReadLine(); not allowed
            Console.WriteLine(name.GetType());
            int num = 5;
            Console.WriteLine(num.GetType());

            //CONVERSION, PARSING
            string numberInput = Console.ReadLine();
            int parsedInput = int.Parse(numberInput);
            //int parsedInput = int.Parse("Hello); - will throw Exception
            Console.WriteLine(parsedInput);

            string doubleInput = Console.ReadLine();
            double parsedDouble = double.Parse(doubleInput);
            Console.WriteLine(parsedDouble);

            string secondNumberInput = Console.ReadLine();
            int secondParsedInteger = Convert.ToInt32(secondNumberInput);
            double secondParsedDouble = Convert.ToDouble(secondNumberInput);

            Console.WriteLine(secondParsedInteger);


            //NOT THROWING EXCEPTION
            string input = Console.ReadLine();
            int parsingResult;
            bool success = int.TryParse(input, out parsingResult);
            Console.WriteLine(parsingResult);
            Console.WriteLine(success);

            int parsingResult2;
            bool secondSuccess = int.TryParse("Hello", out parsingResult2);
            Console.WriteLine(parsingResult);
            Console.WriteLine(secondSuccess);
            Console.ReadLine();
        }
    }
}
