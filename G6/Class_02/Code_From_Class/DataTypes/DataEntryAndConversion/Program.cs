using System;

namespace DataEntryAndConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Please insert your name: ");
            //string name = Console.ReadLine();

            //Console.WriteLine($"HELLO THERE {name}");


            // Type.Parse
            // will throw exception if string is not in valid format or it has null as a value
            //Console.WriteLine("Please enter first number:");
            //string number1 = Console.ReadLine();
            //Console.WriteLine("Please enter second number:");
            //string number2 = Console.ReadLine();

            //int convertedNumber1 = int.Parse(number1);
            //int convertedNumber2 = int.Parse(number2);

            //Console.WriteLine(convertedNumber1 + convertedNumber2);

            // Convert.ToType
            // does not throw exception if the value is null
            //Console.WriteLine("Please enter first number:");
            //string number1 = Console.ReadLine();
            //Console.WriteLine("Please enter second number:");
            //string number2 = Console.ReadLine();

            //int convertedNumber1 = Convert.ToInt32(null);
            //int convertedNumber2 = Convert.ToInt32(number2);

            //Console.WriteLine(convertedNumber1 + convertedNumber2);

            //Type.TryParse(value, out variable)

            Console.WriteLine("Please insert number1:");
            string number1 = Console.ReadLine();

            Console.WriteLine("Please insert number2:");
            string number2 = Console.ReadLine();
            // int conversionResult;
            // bool isConversionSuccess = int.TryParse(number, out conversionResult);
            //Console.WriteLine($"Is conversion successfull: {isConversionSuccess}");
            //Console.WriteLine($"Converted value: {conversionResult}");
            bool isConversion1Success = int.TryParse(number1, out int conversionResult1);
            bool isConversion2Success = int.TryParse(number2, out int conversionResult2);

            if(isConversion1Success && isConversion2Success)
            {
                Console.WriteLine($"The result is {conversionResult1 + conversionResult2}");
            } else
            {
                Console.WriteLine("You inserted invalid numbers");
            }

            //int test = 3;
            //if(test == 3)
            //{
            //    Console.WriteLine("Three");
            //} else if (test == 2)
            //{
            //    Console.WriteLine("Two");
            //} else if (test == 1)
            //{
            //    Console.WriteLine("One");
            //} else
            //{
            //    Console.WriteLine("Unknown number");
            //}

            int dayOfWeek = 5;

            switch(dayOfWeek)
            {
                case 1:
                    Console.WriteLine("Working day");
                    break;
                case 2:
                    Console.WriteLine("Working day");
                    break;
                case 3:
                    Console.WriteLine("Working day");
                    break;
                case 4:
                    Console.WriteLine("Working day");
                    break;
                case 5:
                    Console.WriteLine("Working day");
                    break;
                case 6:
                    Console.WriteLine("Not Working day");
                    break;
                case 7:
                    Console.WriteLine("Not Working day");
                    break;
                default:
                    Console.WriteLine("Not such day!");
                    break;
            }

            // Even better
            switch (dayOfWeek)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Working day");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("Not Working day");
                    break;
                default:
                    Console.WriteLine("Not such day!");
                    break;
            }


            //Exercise5

            int treeBranches = 12;
            int applesOnBranch = 8;
            int applesInBasket = 5;

            Console.Write("Please insert the number of trees");
            string userInput = Console.ReadLine();
            bool isSuccess = int.TryParse(userInput, out int numberOfTrees);
            if(isSuccess)
            {
                int numberOfTotalApples = numberOfTrees * treeBranches * applesOnBranch;
                int result = numberOfTotalApples / applesInBasket;
                Console.WriteLine($"The number of baskets that you will need for {numberOfTrees} trees is {result}");
            } else
            {
                Console.WriteLine("You entered invalid number");
            }



            Console.ReadLine();
        }
    }
}
