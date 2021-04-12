using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<long, string> phoneBook = new Dictionary<long, string>
            {
                {72123456, "Risto"},
                {70654321, "Adis" },
                {71123456, "Martin" },
                {76123456, "Nikola" },
                {76654321, "Aleksandar" }
            };

            Console.WriteLine("Search: ");
            string search = Console.ReadLine();

            bool cast = long.TryParse(search, out long number);
            bool phoneFound = false;

            if (cast)
            {
                //phoneBook[number]
                bool numberFound = phoneBook.TryGetValue(number, out string name);

                if (numberFound)
                {
                    Console.WriteLine($"{name}: {number}");
                    phoneFound = true;
                }
            }
            else
            {
                foreach (var phoneNumber in phoneBook)
                {
                    if (phoneNumber.Value == search)
                    {
                        Console.WriteLine($"{phoneNumber.Value}: {phoneNumber.Key}");
                        phoneFound = true;
                        break;
                    }
                }
                
                //Default [0, null]
                //KeyValuePair<long, string> foundNumber = phoneBook.FirstOrDefault(x => x.Value == search);

                //if (foundNumber.Value != null)
                //{
                //    Console.WriteLine($"{foundNumber.Value}: {foundNumber.Key}");
                //    phoneFound = true;
                //}
            }

            if (!phoneFound)
                Console.WriteLine("Phone not found");
        }
    }
}
