using System;

namespace HelloWorldApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console is a class that lives in System namespace that allows us to interact with the console
            // Write is a method of Console (class) that writes some text that we pass as arg and stays at the same line
            //set the background color to different one
            Console.BackgroundColor = ConsoleColor.Yellow;
            // set the text color to different one
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Hello");


            // Write is a method of Console (class) that writes some text that we pass as arg and goes in new line
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
