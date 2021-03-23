using System;

namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var argument in args) 
            {
                Console.WriteLine(argument);
            };

            //Console.WriteLine("Hello World!");
            string consoleInput = Console.ReadLine();
            Console.WriteLine(consoleInput);
        }


        
    }
}
