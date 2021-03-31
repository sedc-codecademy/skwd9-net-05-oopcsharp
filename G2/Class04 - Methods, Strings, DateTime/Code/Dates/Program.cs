using System;

namespace Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            //get current Date and Time
            DateTime currentDateAndTime = DateTime.Now;
            Console.WriteLine(currentDateAndTime);
            //get current Universal Date and Time
            DateTime utcDateTime = DateTime.UtcNow;
            Console.WriteLine(utcDateTime);

            //create empty Date with default values
            DateTime emptyDateTime = new DateTime();
            Console.WriteLine(emptyDateTime);

            DateTime customDate = new DateTime(1999, 11, 5);
            Console.WriteLine(customDate);

            string stringDate = "31-03-2021";
            //create DateTime from string
            DateTime convertedDate = DateTime.Parse(stringDate);
            Console.WriteLine(convertedDate);

            //get current date
            DateTime currentDate = DateTime.Today;
            Console.WriteLine(currentDate);

            //add two days to the given datetime
            DateTime twoDaysFromToday = currentDate.AddDays(2);
            Console.WriteLine(twoDaysFromToday);

            //go one month back from the given datetime
            DateTime oneMonthBack = currentDate.AddMonths(-1);
            Console.WriteLine(oneMonthBack);

            DateTime oneMinuteBack = currentDateAndTime.AddMinutes(-1);
            Console.WriteLine(oneMinuteBack);

            Console.WriteLine(currentDateAndTime.Month);
            Console.WriteLine(currentDateAndTime.Year);
            Console.WriteLine(currentDateAndTime.Date);
            Console.WriteLine(currentDateAndTime.Day);

            string firstDateFormat = currentDateAndTime.ToString("MM/dd/yyyy");
            Console.WriteLine(firstDateFormat);
            string secondDateFormat = currentDateAndTime.ToString("dddd MMMM yyyy");
            Console.WriteLine(secondDateFormat);
            string thirdDateFormat = currentDateAndTime.ToString("MM-dd-yyyy HH:mm:ss");
            Console.WriteLine(thirdDateFormat);

            string formatedDate = String.Format("Today is {0:dd-MMMM-yyyy}", currentDateAndTime);
            Console.WriteLine(formatedDate);

            Console.ReadLine();
        }
    }
}
