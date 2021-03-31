using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Ana";
            string surname = "Petkovska";

            //Concatenation
            string firstGreeting = "Hello" + " " + name;
            //interpolation
            string secondGreeting = $"Hello {name}";
            //format
            string thirdGreeting = String.Format("Hello {0} {1}", name, surname);
            Console.WriteLine(thirdGreeting);

            // Console.WriteLine("Check your c:\ drive");
            // Console.WriteLine("Check your "drive" ");
            Console.WriteLine("Hello \n SEDC");

            //ESCAPING
            Console.WriteLine("Check your c:\\ drive");
            Console.WriteLine("Check your \"drive\" ");
            Console.WriteLine("Hello \\n SEDC");

            Console.WriteLine(@"Check your C:\drive and ""fair"". \n This would mean new line. ");

            //FORMAT
            string percent = System.String.Format("This is {0:P}", 125.5);
            Console.WriteLine(percent);

            string currency = String.Format("Currency: {0:C}", 120);
            Console.WriteLine(currency);

            string number = String.Format("Number: {0:N}", 125000);
            Console.WriteLine(number);

            Console.WriteLine(String.Format("{0:0##-###-###}", 072555673));
            Console.WriteLine(String.Format("| {0,10} | {1,10} |", "Id", "Order"));
            Console.WriteLine(String.Format("| {0,10} | {1,10} |", 12, "Apples"));

            string firstString = "We are from SEDC";
            Console.WriteLine(firstString.ToLower());
            Console.WriteLine(firstString.ToUpper());

            string message = "We are learning C# and it is FUN and EASY. Okay maybe just FUN";
            //method Split splits by a given character and returns an array of the splited strings
            string[] splitedStrings = message.Split('.');
            foreach (string str in splitedStrings)
            {
                Console.WriteLine(str);
            }

            bool startsWith = message.StartsWith("We");
            Console.WriteLine(startsWith);

            //Find the index on which the given substring starts
            int index = message.IndexOf("learning");
            Console.WriteLine(index);
            int secondIndex = message.IndexOf("SEDC");
            Console.WriteLine(secondIndex);

            //Find a substring starting from a given index, with a given length
            string substring = message.Substring(3, 10);
            Console.WriteLine(substring);

            string secondMessage = "  We are learning C# and it is FUN and EASY. Okay maybe just FUN   ";
            Console.WriteLine(secondMessage);
            Console.WriteLine(secondMessage.Length);

            //Remove spaces at the beginning and end of the string
            string trimmedString = secondMessage.Trim();
            Console.WriteLine(trimmedString);
            Console.WriteLine(trimmedString.Length);

            char[] charsArray = trimmedString.ToCharArray();
            Console.WriteLine(charsArray[3]);

            //Join characters into a string, by separating them with a given character
            Console.WriteLine(String.Join("", charsArray));
            Console.WriteLine(String.Join("-", charsArray));

            Console.WriteLine(secondMessage.Equals(trimmedString));
            Console.WriteLine(secondMessage.Equals(trimmedString, StringComparison.InvariantCultureIgnoreCase));

            Console.ReadLine();

        }
    }
}
