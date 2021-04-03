using System;

namespace Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating an empty DateTime
            DateTime date = new DateTime();
            Console.WriteLine(date);

            //Creating a custom DateTime       Year Month Day
            DateTime customDate = new DateTime(1989, 5, 21);
            Console.WriteLine(customDate);

            //Converting from string to DateTime
            //string stringDate = "12.15.2012";
            //string stringDate = "12/15/2012";
            //string stringDate = "12/15/12";
            //string stringDate = "dec.15.12";
            string stringDate = "12-15-2012";

            // If we provide not clear formats, error will occure
            //string stringDate = "15-2012";

            DateTime convertedDate = DateTime.Parse(stringDate);
            Console.WriteLine(stringDate);

            // Creates a DateTime with the current Date
            DateTime currentDate = DateTime.Today;
            // Creates a DateTime with the current Date and Time
            DateTime currentDateTime = DateTime.Now;

            DateTime addedDays = currentDateTime.AddDays(5);
            DateTime removeDays = currentDateTime.AddDays(-3);
            DateTime addMonths = currentDateTime.AddMonths(2);
            DateTime addYears = currentDateTime.AddYears(5);
            DateTime addHours = currentDateTime.AddHours(12);
            DateTime removeHours = currentDateTime.AddHours(-4);

            Console.WriteLine(currentDateTime);
            Console.WriteLine(removeHours);

            //Extracting single values from a DateTime
            int month = currentDateTime.Month;
            int day = currentDateTime.Day;
            int year = currentDateTime.Year;
            int hour = currentDateTime.Hour;
            Console.WriteLine(hour);

            Console.WriteLine("======");

            //Formating Dates
            string dateFormat1 = currentDateTime.ToString("dd/MM/yyyy");
            string dateFormat2 = currentDateTime.ToString("yyyy-dd-MM");
            string dateFormat3 = currentDateTime.ToString("dddd, dd MMMM yyyy");
            string dateFormat4 = string.Format("Today is {0:dd/MM/yy}, {0:t}", currentDateTime);
            string dateFormat5 = string.Format("Today is {0:dd-MMMM-yyyy}, {0:t}", currentDateTime);

            Console.WriteLine(dateFormat5);



            Console.ReadLine();
        }
    }
}
