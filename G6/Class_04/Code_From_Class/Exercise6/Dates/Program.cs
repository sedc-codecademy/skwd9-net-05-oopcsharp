using System;
using System.Globalization;

namespace Dates
{
    class Program
    {
        static void Exercise4()
        {
            DateTime today = DateTime.Today;
            Console.WriteLine(today.AddDays(3));
            Console.WriteLine(today.AddMonths(1).AddDays(3));
            Console.WriteLine(today.AddYears(-1).AddMonths(-2));
            Console.WriteLine(string.Format("{0:MMMM}", today));
            Console.WriteLine(string.Format("{0:yyyy}", today));
        }
        static void Main(string[] args)
        {
            // Working with dates

            DateTime newDate = new DateTime();
            // Console.WriteLine(newDate);

            // creating a custom date
            DateTime customDate = new DateTime(2021, 4, 30);
            // Console.WriteLine(customDate);

            // converting string to DateTime
            // string stringDate = "12.15.2020";
            // string stringDate = "12/15/2020";
            // string stringDate = "12/15/20";
            // string stringDate = "dec.15.12";
            string stringDate = "12-15-2020";
            DateTime convertedDate = DateTime.Parse(stringDate, CultureInfo.InvariantCulture);
            // Console.WriteLine(convertedDate);

            // Formating dates

            string stringDate1 = customDate.ToString("MM/dd/yyyy");
            string stringDate2 = customDate.ToString("dddd, dd MMMM yyyy");
            string stringDate3 = string.Format("Today is {0:dd-MMMM-yyyy}", customDate);
            string stringDate4 = string.Format("Today is {0:dd-MMMM-yyyy}, {0:t}", customDate);
            // Console.WriteLine(stringDate4);
            // Console.WriteLine(stringDate1);

            // creating DateTime with the current Date
            DateTime currentDate = DateTime.Today;

            // creating DateTime with the current Date and Time
            DateTime currentDateTime = DateTime.Now;
            // Console.WriteLine(currentDateTime);

            // Adding day, months, years, hours...
            // Adding or removing DAYS from DateTime date
            DateTime addedDays = currentDateTime.AddDays(3);
            DateTime removedDays = currentDateTime.AddDays(-2);
            // Adding or removing MONTHS from DateTime date
            DateTime addedMonths = currentDateTime.AddMonths(3);
            DateTime removedMonths = currentDateTime.AddMonths(-2);
            Console.WriteLine($"Value after adding months: {addedMonths}");
            Console.WriteLine($"Value after removing months: {removedMonths}");

            // Adding or removing HOURS from DateTime date
            DateTime addedHours = currentDateTime.AddHours(3);
            DateTime removedHours = currentDateTime.AddHours(-2);
            Console.WriteLine($"Value after adding HOURS: {addedHours}");
            Console.WriteLine($"Value after removing HOURS: {removedHours}");

            Exercise4();
        }
    }
}
