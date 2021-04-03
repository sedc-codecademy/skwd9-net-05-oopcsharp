using System;

namespace SEDC.Class05.Dates.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating DateTime object and getting the default date
            DateTime date = new DateTime();
            //Console.WriteLine(date);
            //Creating a custom date
            DateTime yesterday = new DateTime(2021, 04, 02);
            Console.WriteLine($"This is yesterday's date {yesterday}");

            // DateTime current date
            DateTime todaysDate = DateTime.Today;
            Console.WriteLine(todaysDate);
            DateTime currentDateAndTime = DateTime.Now;
            Console.WriteLine(currentDateAndTime);

            //Parse DateTime to string and formating date
            string stringTodaysDate = Convert.ToString(todaysDate);
            string formatedDate = string.Format("{0:dd-MM-yyyy}", todaysDate);
            string usDate = string.Format("{0:MM-dd--yyyy hh}", todaysDate);
            Console.WriteLine($"The US date is the following with hours {usDate}");
            Console.WriteLine(formatedDate);
            //Console.WriteLine(stringTodaysDate);

            //DateTime adding days, months and yers to a specific date
            DateTime dateOneMonthFromNow = todaysDate.AddMonths(1);
            Console.WriteLine("The date one month from now will be " + dateOneMonthFromNow);
            DateTime twentyDaysFromNow = todaysDate.AddDays(20);
            Console.WriteLine($"The date in 20 days will be {twentyDaysFromNow}");
            //Get the date 20 days ago
            DateTime twentyDaysAgo = todaysDate.AddDays(-20);
            Console.WriteLine($"The date 20 days ago was {twentyDaysAgo}");

            //Get the values from DateTime
            //Get the month only from a date
            int month = todaysDate.Month;
            int currentDay = todaysDate.Day;
            int year = todaysDate.Year;
            Console.WriteLine($"The current month is {month}th");

            Console.ReadLine();
        }
    }
}
