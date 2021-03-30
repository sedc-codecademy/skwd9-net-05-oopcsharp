using System;

namespace SEDC.CsharpOop.Class_02.FromLastClass
{
    class Program
    {
        static void Main(string[] args)
        {
            #region firstPart
            //double a1 = 1;
            //double b = 2;
            //double c = 3;
            //double d = 4;
            //double nums = 4;
            //double sum = (a1 + b + c + d) / 4;
            //Console.WriteLine(sum);

            Console.ReadLine();

            string str = "3.7";

            // this will pass fine
            double parsedInt = double.Parse(str);
            Console.WriteLine(parsedInt);

            //string str2 = "Trajan";

            // this will throw FormatException
            //int parsedInt2 = int.Parse(str2);

            //long bigNum = 123123123;
            //string str3 = "123";

            //int convertedBigNum = Convert.ToInt32(bigNum);
            //long convertStringToLong = Convert.ToInt64(str3);

            string str4 = "312";
            bool isValidInput = int.TryParse(str4, out int parsedInteger);

            Console.WriteLine(isValidInput);
            if (isValidInput)
            {
                Console.WriteLine("Valid Parsing " + parsedInteger);
                // do something...
            }
            else
            {
                Console.WriteLine("Not valid parsing");
                // do something else...
            }

            string input = Console.ReadLine();
            if(!int.TryParse(input, out int a))
            {
                Console.WriteLine("Please enter valid input!");
            }
            #endregion

            // SWITCH

            int input1 = 6;

            //if(input1 == 1)
            //{

            //}else if(input1 == 2)
            //{

            //}

            switch(input1)
            {
                case 1:
                    // do something...
                    Console.WriteLine(input1);
                    break;
                case 2:
                    // do something...
                    Console.WriteLine(input1);
                    break;
                case 3:
                    // do something...
                    Console.WriteLine(input1);
                    break;
                case 4:
                    // do something...
                    Console.WriteLine(input1);
                    break;
                case 5:
                case 6:
                    Console.WriteLine("We are the same " + input1);
                    break;
                default:
                    Console.WriteLine("Not valid input SWITCH");
                    break;
            }


            Console.ReadLine();
        }
    }
}
