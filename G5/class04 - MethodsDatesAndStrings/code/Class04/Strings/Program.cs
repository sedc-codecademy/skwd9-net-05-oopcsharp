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
        }
    }
}
