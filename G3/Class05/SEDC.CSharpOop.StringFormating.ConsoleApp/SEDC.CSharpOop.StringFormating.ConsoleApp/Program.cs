using System;

namespace SEDC.CSharpOop.StringFormating.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region stringFormat
            //string firstName = "Damjan";
            //string lastName = "Stojanovski";
            //string fullName = string.Format("My fullname is {0} {1}", firstName, lastName);

            //Console.WriteLine(fullName);

            ////Format can format strings in a certain way
            //int thousand = 1000;
            //string thousandDollars = string.Format("The value of the money is {0:C}", thousand);
            //Console.WriteLine(thousandDollars);

            ////Format string to display percent
            //string fiftyPercent = string.Format("This is {0:P}", 0.5);
            //Console.WriteLine(fiftyPercent);

            ////Custom format of string
            //// Check the syntax for custom formating
            //string mkdMobileNumberFormat = string.Format("This is {0:(###) ###-####}", 075123123);
            //Console.WriteLine(mkdMobileNumberFormat);
            #endregion

            //String Methods
            //ToLower returns a string with all low characters
            //string senence = "Hello it's Saturaday";
            //string sentanceToLower = senence.ToLower();
            //Console.WriteLine(sentanceToLower);

            //ToUpper returns a string with all Upper characters
            //string lowerLettersSentence = "hello there g3 we are learning string methods";
            //string upperCaseLetters = lowerLettersSentence.ToUpper();
            //Console.WriteLine(upperCaseLetters);

            //Trim cleans the empty spaces on the beggining and the end of the string
            //string greeting = "  Hello G3 from string methods    ";
            //Console.WriteLine("The length of the first string is " + greeting.Length);
            //string cleanString = greeting.Trim();
            //Console.WriteLine("The length of the second string is " + greeting.Length);
            //Console.WriteLine(cleanString);

            //Length is a property and returns integer number of characters of a specific stirng
            string demoString = "Hello there";
            int numberOfCharacters = demoString.Length;
            Console.WriteLine($"The number of characters of this demo string is {numberOfCharacters}");

            //StartsWith is a string method that returns a boolean and checks if a certain stirng starts with a sequence of characters
            bool doesDemoStirngStartsWithHello = demoString.StartsWith("Hello");
            bool doesDemoStirngStartsWithH = demoString.StartsWith('h');
            Console.WriteLine($"The demo string {doesDemoStirngStartsWithHello} starts with hello");
            Console.WriteLine($"The demo string {doesDemoStirngStartsWithH} starts with F");

            //IndexOf is string method that goes through a string checks if a certain character exists and returns the index of the character
            string stringExample = "Hello Bob";
            int positionOfB = stringExample.IndexOf('b');
            Console.WriteLine($"The first b in this stirng is at position {positionOfB}");

            //SubString is a method that returns a string which is contained in some other string
            string stringExample3 = "Today is Saturaday and the weekend has started";
            string subStringSentence = stringExample3.Substring(9);
            int indexOfSaturaday = stringExample3.IndexOf("Saturaday");
            string subStringExample2 = stringExample3.Substring(indexOfSaturaday, stringExample3.Length - 17);
            Console.WriteLine(subStringExample2);
            //Console.WriteLine(subStringSentence);

            //Split is a method that returns a string array and the original string is splited by some specific character
            string multipleSentences = "Hello there G3. We are learning c#. Stirng methods are really cool";
            string[] sentences = multipleSentences.Split(".");
            for(int i = 0; i < sentences.Length; i++)
            {
                string clearSentence = sentences[i].Trim();
                Console.WriteLine(clearSentence);
            }

            //ToCharArray is a method that converts the string into array of characters
            string demoString3 = "This stirng will be converted into characters array";
            char[] charArray = demoString3.ToCharArray();
            foreach (char character in charArray)
            {
                if(character.ToString() == "E")
                {
                    Console.WriteLine("There is an E character");
                }
                Console.Write(character + " ");
            }
            Console.ReadLine();
        }
    }
}
