using System;

namespace Workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "The whole group of G6 loves C#They find learning this language fun and easy!";
            // FIRST APPROACH
            //int dotIndex = text.IndexOf(".");
            //if (dotIndex < 0)
            //{
            //    Console.WriteLine("Character (.) is not found!");
            //} else
            //{
            //    string formatedText = text.Substring(dotIndex + 1);
            //    Console.WriteLine(formatedText);
            //}
            // SECOND APPROACH 
            string[] substrings = text.Split(".");
            if (substrings.Length > 1)
            {
                Console.WriteLine(substrings[1]);
            } else
            {
                Console.WriteLine("Character (.) is not found!");
            }
            Console.ReadLine();
        }
    }
}
