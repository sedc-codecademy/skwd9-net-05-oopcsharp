using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            #region String Building
            string academy = "Hello SEDC academy!";

            string group4 = academy + " " + "We are group 4!";
            //Console.WriteLine(group4);
            #endregion

            #region String Formatting
            string greeeting = string.Format("{0} We are group 4!", academy);
            //Console.WriteLine(greeeting);

            string greetMessage = "We are learning C#";
            string greeting2 = string.Format("{1} {0}", group4, greetMessage);
            //Console.WriteLine(greeting2);
            #endregion

            #region String Interpolation
            // syntax from C# 6 and later
            string greetInterpolation = $"{group4} ----- {greetMessage}";
            //Console.WriteLine(greetInterpolation);
            #endregion

            #region Formatting string
            // currency - is connected to system settings (may vary)
            string currency = string.Format("{0:C}", 259);
            //Console.WriteLine(currency);

            // percent
            string percent = string.Format("{0:P}", .5);
            //Console.WriteLine(percent);

            // phone number
            //Console.WriteLine(078123456);
            string phoneNumber = string.Format("{0:0##-###-###}", 078123456);
            //Console.WriteLine(phoneNumber);
            #endregion

            #region Escaping String
            string escapeBackslash = "Check your c:\\ drive";
            string escapeQuotes = "We will have \"fair\" elections";
            string escapeNewLine = "The \\n sign means: new line";
            //Console.WriteLine(escapeBackslash);
            //Console.WriteLine(escapeQuotes);
            //Console.WriteLine(escapeNewLine);

            string escapeBackslash2 = @"Check your c:\ drive";
            string escapeQuotes2 = @"We will have ""fair"" elections";
            string escapeNewLine2 = @"The \n sign means: new line";
            //Console.WriteLine(escapeBackslash2);
            //Console.WriteLine(escapeQuotes2);
            //Console.WriteLine(escapeNewLine2);

            string folderName = "kristina";
            string combo = @$"C:\user\{folderName}\desktop";
            // $@""
            //Console.WriteLine(combo);
            #endregion

            #region String Methods
            string testString = "   We are learning C# and it's fun and easy. Okay maybe just fun.   ";
            string lower = testString.ToLower();
            string upper = testString.ToUpper();
            //Console.WriteLine(lower);
            //Console.WriteLine(upper);

            string trimmed = testString.Trim();
            //Console.WriteLine(trimmed);

            int stringLength = testString.Length;
            int trimmedLength = trimmed.Length;
            //Console.WriteLine(stringLength);
            //Console.WriteLine(trimmedLength);

            //Console.WriteLine(testString.StartsWith("   We"));
            //Console.WriteLine(testString.StartsWith("We"));

            string[] splitted = testString.Split('.');
            //Console.WriteLine(splitted.Length);
            //foreach (string item in splitted)
            //{
            //    Console.WriteLine(item);
            //}

            // index of - returns the starting index of the letter/phrase
            int indexOfString = testString.IndexOf("fun");
            //Console.WriteLine(indexOfString);
            // return -1 if it doesn't find a match
            int indexOfNonExistant = testString.IndexOf("weeheeeee");
            //Console.WriteLine(indexOfNonExistant);

            // substring
            // starting from {parameter} to the end of the string
            string substring1 = testString.Substring(3);
            // starting from {parameter} and take next {secondParameter} characters
            string substring2 = testString.Substring(3, 10);
            //Console.WriteLine(testString);
            //Console.WriteLine(substring1);
            //Console.WriteLine(substring2);

            char[] charactersArray = testString.ToCharArray();
            Console.WriteLine(charactersArray.Length);
            foreach (char item in charactersArray)
            {
                Console.Write($"{item} ");
            }
            #endregion


            Console.ReadLine();

            
        }
    }
}
