using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // string building
            string name = "Viktor";
            int age = 31;

            string hello1 = "Hello " + name + " something else...";
            string hello2 = $"Hello, I am {name} ... {age}";
            string hello3 = string.Format("Hello, I am {0}, and I am {1} years old.", name, age);
            Console.WriteLine(hello3);

            //string formating

            //currency formatter
            string currency = string.Format("{0:C}", 125.66);
            Console.WriteLine(currency);
            //percent formatting
            string percent = string.Format("{0:P}", .5);
            Console.WriteLine(percent);
            //custom fomratting
            string customFormat = string.Format("{0:#-##-###-###}", 178524693);
            Console.WriteLine(customFormat);
            // aligment formatting
            string customAlignment = string.Format("| {0,10} | {1,50} |", "Id", "Order");
            Console.WriteLine(customAlignment);
            // format dates
            string dateString = string.Format("It is now {0:d} at {0:t}", DateTime.Now);
            Console.WriteLine(dateString);

            //escaping string
            string a = "some text \"\" some other text";
            string b = @"some text ""text inside"" some other text";
            string c = "This sign \n means new line";
            string escape_n = "This sign \\n means new line";
            string escape_n_2 = @"This sign \n means new line";
            Console.WriteLine(escape_n_2);

            //string methods
            string ourString = "   We are learning. C# and it is FUN and EASY. Okay maybe just FUN.    ";

            // Makes our string Upper/Lopwer case
            string lower = ourString.ToLower();
            string upper = ourString.ToUpper();
            Console.WriteLine(lower);
            Console.WriteLine(upper);

            // Prints the length of the string
            int ourLength = ourString.Length;
            Console.WriteLine(ourLength);

            // Splits the string and makes an array of strings
            string[] spliitedString = ourString.Split(".");
            Console.WriteLine(spliitedString.Length);
            string str1 = spliitedString[0];
            string str2 = spliitedString[1];
            string str3 = spliitedString[2];
            string str4 = spliitedString[3];
            Console.WriteLine(str2);

            string[] spliitedString2 = ourString.Split("FUN");

            foreach (var str in spliitedString2)
            {
                Console.WriteLine(str);
            }

            //Checks of a string starts with some starting given and returns a boolean
            bool startsWith = ourString.StartsWith("Viktor");
            Console.WriteLine(startsWith);

            //Checks if a string exists and if so returns an index. Returns -1 if the string does not exists.
            //Is case sensitive
            int indexOfString = ourString.IndexOf("F");
            int nonExistingIndexOfString = ourString.IndexOf("f");
            Console.WriteLine(indexOfString);
            Console.WriteLine(nonExistingIndexOfString);

            //Cuts a string in to a substring that starts from index 10 and takes the next 15 characters
            string substring = ourString.Substring(10, 15);
            Console.WriteLine(substring);

            //Creates an array of characters from a given string
            char[] charsArray = ourString.ToCharArray();

            //foreach (var chars in charsArray)
            //{
            //    Console.WriteLine(chars);
            //}

            // It trims the white spaces at the front and the back of the string
            string trimmedString = ourString.Trim();
            Console.WriteLine(trimmedString);

            Console.ReadLine();
        }
    }
}
