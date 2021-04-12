using System;
using System.Collections.Generic;

namespace Exercise1
{
    class Program
    {
        public static void PrintPhone(Dictionary<string, long> phoneBook, string name)
        {
            if (!phoneBook.ContainsKey(name))
            {
                Console.WriteLine($"There is no {name} in this phoneBook. Sorry!");
                return;
            }
            Console.WriteLine($"{name}'s phone is: 0{phoneBook[name]}");
        }
        static void Main(string[] args)
        {
            Dictionary<string, long> phoneBook = new Dictionary<string, long>()
            {
                {"Bob", 70993241 },
                {"Will", 71234232 },
                {"Meg", 72778900 },
                {"Jill", 71562110 },
                {"Buck", 71119804 }
            };
            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();
            PrintPhone(phoneBook, name);
            Console.ReadLine();
        }
    }
}
