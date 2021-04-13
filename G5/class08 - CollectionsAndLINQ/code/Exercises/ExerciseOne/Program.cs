using System;
using System.Collections.Generic;

namespace ExerciseOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> PhoneBook = new Dictionary<string, int>();
            PhoneBook.Add("Viktor", 123456);
            PhoneBook.Add("Angela", 321314);
            PhoneBook.Add("Robert", 433245);
            PhoneBook.Add("Marko", 324451);
            PhoneBook.Add("Igor", 442312);

            Console.Write("Enter name here: ");
            string input = Console.ReadLine();

            //PrintPhone1(PhoneBook, input);
            PrintPhone2(PhoneBook, input);

            Console.ReadLine();
        }

        public static void PrintPhone1(Dictionary<string, int> phoneBook, string name) 
        {
            if (phoneBook.ContainsKey(name))
            {
                Console.WriteLine($"{name}'s phone number is: {phoneBook[name]}");
            }
            else 
            {
                Console.WriteLine($"There is no {name} in this phonebook!");
            }
        }

        public static void PrintPhone2(Dictionary<string, int> phoneBook, string name) 
        {
            foreach (var contactName in phoneBook)
            {
                if (contactName.Key == name) 
                {
                    Console.WriteLine($"{contactName.Key}'s phone number is: {contactName.Value}");
                    return;
                }
            };

            Console.WriteLine($"There is no {name} in this phonebook!");
        }
    }
}
