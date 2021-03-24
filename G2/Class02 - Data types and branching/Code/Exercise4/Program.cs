using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int credits = 102;
            int smsCredits = 5;
            int numOfMessages = credits / smsCredits;
            Console.WriteLine($"Number of messages: {numOfMessages}");

            Console.ReadLine();
        }
    }
}
