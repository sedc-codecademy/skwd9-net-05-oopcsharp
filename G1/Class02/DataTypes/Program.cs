using System;
using System.Globalization;
using System.Text;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int numberOfStudents;
            //numberOfStudents = 14;

            int numberOfStudents = 14;

            Console.WriteLine(numberOfStudents);

            long bigNumber = 1212121212121212121;
            short shortNumber = 10;

            char firstChar = 'a';
            string statement = "Welcome to SEDC!";

            float currencyRate = 61.5f;
            double currencyRateDouble = 65.1;

            DateTime today = new DateTime(2021, 3, 24);
            Console.WriteLine(today);
            DateTime now = DateTime.Now;
            Console.WriteLine(now);

            //Console.OutputEncoding = Encoding.UTF8;
            //Console.WriteLine(now.ToString("dd MMMM yyyy", new CultureInfo("en-US")));

            Console.WriteLine(now.ToString(new CultureInfo("en-US")));

            int a = 5;
            int b = 7;

            //Console.WriteLine(a);
            //a = b;
            //Console.WriteLine(a);

            int c = a + b;
            Console.WriteLine(c);

            Console.WriteLine(a);
            //a = a + b;
            a += b;
            Console.WriteLine(a);
        }
    }
}
