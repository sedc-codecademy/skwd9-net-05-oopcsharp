using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // string building
            string fullName = "Jane Doe";
            string age = "32";
            //Concatanation
            // string userInfo = fullName + " " + "is female";

            // string formatting
            // string userInfo = string.Format("{0} is female and she is {1} years old", fullName, age);

            // interpolation

            //string userInfo = $"{fullName} is female and she is {age} years old";
            //Console.WriteLine(userInfo);

            //percent
            string stringWithPercent = string.Format("{0:P}", .33);
            // Console.WriteLine(stringWithPercent);

            //currency = may vary as it is connected to you system settings
            string currency = string.Format("{0:C}", 150);
            // Console.WriteLine(currency);

            // phone numbers
            string phoneNum = string.Format("{0:+389##-###-###}", 078555111);
            //Console.WriteLine(phoneNum);

            // escaping characters

            // Console.WriteLine("Check your c:\\drive");
            // Console.WriteLine("Vlatko Ilevski said: \"Lele lugje sto napravivme\"");
            string extraText = "this should work";
            //Console.WriteLine($@"Check your c:\drive, {extraText}");
            //Console.WriteLine(@"Vlatko Ilevski said: ""Lele lugje sto napravivme""");

            // string methods
            string testString = "   We are learning C# and it is fun and easy. Okay maybe just fun. This is for test   ";
            //Console.WriteLine(testString.ToUpper());
            //Console.WriteLine(testString.ToLower());
            //Console.WriteLine(testString.Length);
            //Console.WriteLine(testString.Trim());
            //Console.WriteLine(testString.Trim().ToUpper());

            // StartsWith() => returns true or false
            // Console.WriteLine(testString.StartsWith("   We are "));

            //indexOf => returns index (int)
            //Console.WriteLine(testString.IndexOf("We"));
            //Console.WriteLine(testString.IndexOf("Weasjkhflasfh"));

            //split => returns array
            //string[] splitedTestString = testString.Split(".");
            //foreach (string text in splitedTestString)
            //{
            //    Console.WriteLine(text);
            //}
            //Console.WriteLine(splitedTestString.Length);
            //Console.WriteLine(splitedTestString[0]);
            //Console.WriteLine(splitedTestString[1]);

            // substring => returns new string
            string substring1 = testString.Substring(5);
            // Console.WriteLine(substring1);
            string substring2 = testString.Substring(6, 3);

            // ToCharArray
            char[] charsFromTestString = testString.ToCharArray();
            Array.Reverse(charsFromTestString);
            string result = string.Join("", charsFromTestString);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
