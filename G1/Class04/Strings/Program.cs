using System;
using System.Globalization;
using System.Text;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Risto";
            string surname = "Panchevski";
            string fullname = "Hello " + name + " " + surname + "!";
            Console.WriteLine(fullname);
            string fullname2 = string.Format("Hello {0} {1}!", name, surname);
            Console.WriteLine(fullname2);
            string fullname3 = $"Hello {name} {surname}!";
            Console.WriteLine(fullname3);

            double passedStudents = 0.9;
            string percentText = string.Format(@"The exam was passed by {0:P}", passedStudents);
            Console.WriteLine(percentText);
            Console.WriteLine($@"The exam was passed by {passedStudents:P}");

            double price = 10.7;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine($"The price of the milk is {price:C}");
            Console.WriteLine($"The price of the milk is {price.ToString("C", new CultureInfo("en-US"))}");
            int number = 124234234;
            Console.WriteLine($"Number {number:N}");
            Console.WriteLine($"Number {number.ToString("N", new CultureInfo("en-US"))}");

            int phone = 070123456;
            Console.WriteLine($"Phone: {phone:0##-###-###}");
            int staticPhone = 022012123;
            Console.WriteLine($"Phone: {staticPhone:0#/####-###}");

            string header = string.Format("|{0,10}|{1,10}|", "Product", "Price");
            int milkPrice = 50;
            string product1 = string.Format("|{0,10}|{1,10}|", "Milk", milkPrice.ToString("C"));
            Console.WriteLine(header);
            Console.WriteLine(product1);


            string headerTemp = $"|{"Product",10}|{"Price",10}|";
            string product1Temp = $"|{"Milk",10}|{milkPrice.ToString("C"),10}|";
            Console.WriteLine(headerTemp);
            Console.WriteLine(product1Temp);

            //Function
            string statement = "   We are learning C# and it is FUN and EASY.   Okay maybe just FUN.  ";
            Console.WriteLine(statement);
            Console.WriteLine(statement.ToLower());
            Console.WriteLine(statement.ToUpper());
            Console.WriteLine($"String length: {statement.Length}");
            string trimmedStatement = statement.Trim();
            Console.WriteLine(trimmedStatement);

            string[] splitString = trimmedStatement.Split('.', StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(string.Join("\n", splitString));

            string phoneNumber = "070123456";
            bool validPhone = phoneNumber.StartsWith("07");
            Console.WriteLine(validPhone);
            bool startWithWe = trimmedStatement.StartsWith("we", StringComparison.InvariantCultureIgnoreCase);
            Console.WriteLine(startWithWe);

            int indexOfFun = statement.IndexOf("FUN and EASY");
            int indexOfNone = statement.IndexOf("Not EASY");
            Console.WriteLine($"Fun starts at: {indexOfFun}");
            Console.WriteLine($"Not EASY starts at: {indexOfNone}");

            string learning = statement.Substring(10, 8);
            Console.WriteLine($"Substring: {learning}");

            char[] charArray = trimmedStatement.ToCharArray();
            string backToString = string.Join(", ", charArray);
            Console.WriteLine(backToString);
        }
    }
}
