using System;

namespace SEDC.CSharpOop.Class_2.Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num1 = 3;
            //int num2 = 83;
            //int result = num1 + num2;
            short smallNum = 175;
            int longNumber = 749;
            long result = smallNum + longNumber;
            //Console.WriteLine(result);

            //Summing int and string
            int firstOperand = 56;
            string secondOperand = "Damjan";
            string resultConcat = firstOperand + secondOperand;
            //Console.WriteLine("The sum of a int and a string is " + resultConcat);

            //Modulus
            short ten = 10;
            short three = 3;
            int modulusResult = ten % three;
            Console.WriteLine("The reminder of the modulus operation is " + modulusResult);

            // Logical operators
            bool logicalOr = true || false;
            Console.WriteLine("The logical or for true || false returnes " + logicalOr);
            bool logicalAnd = false && true;
            Console.WriteLine("The logical or for false && true returnes " + logicalAnd);
            //Console.WriteLine("The result form the sum of " + num1 + " " + "and " + num2 + " is "  + result);
            // Bitwise XOR
            int numberOne = 14;
            int numberTwo = 17;
            int resultXor = numberOne ^ numberTwo;
            Console.WriteLine("The result form the XOR operation is " + resultXor);

            //Logical not
            bool isHavingClass = true;
            bool isHavingClassNot = !isHavingClass;

            Console.WriteLine(isHavingClassNot);

            //Comparation in C#
            int numberThree = 7;
            int numberSeven = 3;

            bool isSame = numberThree == numberSeven;
            Console.WriteLine("The number " + numberThree + " is " + isSame + "equal");
            //bool falseBool = false;
            // This gives an error we can not compare integer and boolean
            //if(numberSeven == falseBool)
            //{
            //}
            //This comparison is ok
            //if(numberThree == numberSeven)
            //{
            //}

            //Exercise 3
            int someRandomNumber = 54;
            string someRandomText = "Text";
            string resultConcat2 = someRandomNumber + someRandomText;
            Console.WriteLine(resultConcat2);

            //Exercise 4
            short totalCredit = 102;
            short smsCreditCost = 5;
            int totalSMS = totalCredit / smsCreditCost;

            Console.WriteLine("The total number of SMS we can send are " + totalSMS);
        }
    }
}
