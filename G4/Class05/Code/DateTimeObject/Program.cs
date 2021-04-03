using System;

namespace DateTimeObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello DateTime!");
            Console.WriteLine("--------------------------");

            // empty DateTIme
            // it return the default value of the DateTime object
            DateTime emptyDate = new DateTime();
            //Console.WriteLine(emptyDate);

            DateTime customDate = new DateTime(2021, 4, 3);
            //Console.WriteLine(customDate);

            string stringDate1 = "03-08-2021";
            string stringDate2 = "03.08.2021";
            string stringDate3 = "03/08/2021";
            string stringDate4 = "03/08/21";
            string stringDate5 = "mar.08.2021";
            string stringDate6 = "march.08.2021";

            // different from my date time setting from Windows
            string stringDate7 = "27-03-2021";
            // also invalid, cannot read the whole string
            string stringDate8 = "march eighth two thousand twenty-one";

            // conversion / parsing from string to DateTime type
            // invalid date time
            DateTime convertedDate = DateTime.Parse(stringDate6);
            //Console.WriteLine(convertedDate);

            // Current day with time
            DateTime currentDate = DateTime.Now;
            Console.WriteLine(currentDate);

            // Current day with defualt time
            DateTime currentDay = DateTime.Today;
            //Console.WriteLine(currentDay);

            // return day of week - with letters
            DayOfWeek dayOfWeekToday = currentDate.DayOfWeek;
            //Console.WriteLine(dayOfWeekToday);

            // to add days/month/years
            DateTime addedDays = currentDate.AddDays(3);
            DateTime addedMonths = currentDate.AddMonths(3);
            DateTime addedYears = currentDate.AddYears(3);

            Console.WriteLine("--------------------------");
            //Console.WriteLine(addedDays);
            //Console.WriteLine(addedMonths);
            //Console.WriteLine(addedYears);

            // remove days/months/years
            DateTime removedDays = currentDate.AddDays(-3);
            //Console.WriteLine(removedDays);

            // formatting date time
            string dateFormat1 = currentDate.ToString("MM/dd/yyyy");
            string dateFormat2 = currentDate.ToString("dddd, dd MM yyyy");
            string dateFormat3 = string.Format("Today is {0:MM/dd/yyyy}, {0:dddd}", currentDate);
            string dateFormat4 = string.Format("Today is {0:dd-MMMM-yyyy}, {0:t}", currentDate);

            Console.WriteLine(dateFormat1);
            Console.WriteLine(dateFormat2);
            Console.WriteLine(dateFormat3);
            Console.WriteLine(dateFormat4);

            Console.WriteLine(currentDate.Year);

            Console.ReadLine();
        }
    }
}
