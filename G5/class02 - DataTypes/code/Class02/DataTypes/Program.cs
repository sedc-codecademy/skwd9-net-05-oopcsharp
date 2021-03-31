using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //numbers
            int integerVariable1 = 5;
            int integerVariable2;
            integerVariable2 = 10;
            integerVariable2 = 100;

            short shortVariable = 32000;
            long longVariable = 10000000000000;

            float floatVariable = 21.112310f;
            double doubleVariable = 25.178;           
            double doubleVariable2 = 6;
            decimal decimalVariable = 124.44m;

            //text
            string name = "Viktor";
            char fistLetter = 'V';

            bool booleanVariable = true;

            DateTime dateTimeVariable = DateTime.Now;
            Console.WriteLine(dateTimeVariable);


            string name1 = "Viktor";
            string lastName = "Jakovlev";
            string fullName = name1 + " " + lastName;
            Console.WriteLine(fullName);

            Console.ReadLine();
        }
    }
}
