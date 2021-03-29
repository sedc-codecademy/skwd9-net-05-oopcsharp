using System;

namespace SEDC.CSharpOop.Class_02.DataConvertion
{
    class Program
    {
        static void Main(string[] args)
        {
            // This way we can input text from the console
            // Everything we input from the console is of type string
            Console.WriteLine("Please enter your name!");
            string name = Console.ReadLine();
            //Console.WriteLine("The name of the user is " + name);
            Console.WriteLine("Please enter your age!");
            string ageInput = Console.ReadLine();
            // 3 methods of data conversion
            // 1 Try.Parse(value)
            //int ageParse = int.Parse(ageInput);
            //int ageParseNull = int.Parse(null);
            //int bob = int.Parse("Bob");

            //2 Convert.ToType(value)
            //int ageConvert = Convert.ToInt32(ageInput);
            //int ageConvertWithNull = Convert.ToInt32(null);
            //int convertStringToInt = Convert.ToInt32("Bob");
            //Console.WriteLine("The real age int is " + ageConvertWithNull);

            // 3 int.TryParse(value, out outputVaraiable)
            //int ageIntTryParse;
            //bool isConversionSuccessfull = int.TryParse(ageInput, out ageIntTryParse);

            //Console.WriteLine("The conversion with tryParse returns " + isConversionSuccessfull + " and the value is " + ageIntTryParse);
            //Console.ReadLine();

            //Branching with IF ELSE
            int numOne = 7;
            int numTwo = 13;
            int numThree = 25;
            //if(numOne > numTwo)
            //{
            //    Console.WriteLine("Number 1 is bigger");
            //}
            //else
            //{
            //    Console.WriteLine("Number 2 is bigger");
            //}

            //if(name == ageInput)
            //{
            //    Console.WriteLine("The name is the same as the age");
            //}
            //else
            //{
            //    Console.WriteLine("The name and the age are different");
            //}
            if((numOne > numTwo) && (numTwo > numThree))
            {
                Console.WriteLine("Number one is the biggest number");
            }
            else if((numTwo > numOne) && (numOne > numThree))
            {
                Console.WriteLine("Number two is the biggest number");
            }
            else
            {
                Console.WriteLine("It is not defined");
            }
        }
    }
}
