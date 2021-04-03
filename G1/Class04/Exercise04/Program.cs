using System;

namespace Exercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;

            DateTime threeDaysFromNow = DateTime.Now.AddDays(3);
            Console.WriteLine(threeDaysFromNow);
            DateTime oneMonthFromNow = now.AddMonths(1);
            Console.WriteLine(oneMonthFromNow);
            DateTime date = now.AddMonths(1).AddDays(3);
            Console.WriteLine(date);

            DateTime date1 = now.AddYears(-1).AddMonths(-3);
            Console.WriteLine(date1);
            Console.WriteLine(now.Month);
            Console.WriteLine(now.Year);
        }
    }
}
