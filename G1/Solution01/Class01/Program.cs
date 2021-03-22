using System;

namespace Class01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");

            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("    *");
            Console.WriteLine("   ***");
            Console.WriteLine("  *****");
            Console.WriteLine(" *******");
            Console.WriteLine("*********");


            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("    *");
            Console.WriteLine("   ***");
            Console.WriteLine("  * * *");
            Console.WriteLine("    *");
            Console.WriteLine("   * *");
            Console.WriteLine("  *   *");
        }
    }
}
