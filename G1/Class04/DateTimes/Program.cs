using System;
using System.Globalization;
using System.Text;

namespace DateTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime();
            Console.WriteLine(date);

            DateTime date1 = new DateTime(2010, 10, 18, 9, 30, 0);
            Console.WriteLine(date1);

            //string stringDate = "10/18/2010 09:30:00";
            string stringDate = "18.10.2010 09:30:00";
            DateTime date2 = DateTime.Parse(stringDate);
            Console.WriteLine(date2);

            DateTime now = DateTime.Now;
            Console.WriteLine(now);

            DateTime utcNow = DateTime.UtcNow;
            Console.WriteLine(utcNow);

            DateTime tenDayFromNow = now.AddDays(10);
            Console.WriteLine(tenDayFromNow);

            DateTime fiveDaysBefore = now.AddDays(-5);
            Console.WriteLine(fiveDaysBefore);

            Console.WriteLine(now.Month);
            
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine(now.ToString("F"));
            Console.WriteLine(now.ToString("MM*yyyy*dd (dddd MMM yyyy z)"));
            Console.WriteLine(now.ToString("dddd MMM yyyy",new CultureInfo("en-GB")));
        }
    }
}
