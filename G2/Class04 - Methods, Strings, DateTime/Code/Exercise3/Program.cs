using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Today;
            Console.WriteLine(today.AddDays(3));
            Console.WriteLine(today.AddMonths(1).AddDays(3));
            Console.WriteLine(today.AddYears(-1).AddMonths(-2));
            Console.WriteLine(today.Month);
            Console.WriteLine(today.Year);
            Console.WriteLine(String.Format("{0:MMMM}", today));
            Console.WriteLine(String.Format("{0:yyyy}", today));
            Console.ReadLine();
        }
    }
}
