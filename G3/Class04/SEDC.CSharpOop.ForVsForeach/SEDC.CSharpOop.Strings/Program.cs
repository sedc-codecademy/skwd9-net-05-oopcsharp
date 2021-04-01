using System;

namespace SEDC.CSharpOop.Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //How we concatinated strings sofar
            string name = "Damjan";
            Console.WriteLine("Hello there " + name);

            //1. string.Format - ako imame poveke argumenti od placeholders extra argumentite gi ignorira
            // Ako imame poveke placeholders od argumenti frla greska
            string fullName = string.Format("My firstname is {0}", name,"Stojanovski");
            Console.WriteLine(fullName);

            //2. String interpolation
            // Imported in C# 6
            string fullName2 = $"My fullname is {name} Stojanovski";
            Console.WriteLine(fullName2);

            // Escape characters in C#
            //1. Escape special characters with \
            string saying = "The politicians are \"honest\"";
            Console.WriteLine(saying);

            //2. Escape special characters with @
            // Escapes all characters except "" (double quotes)
            string saying2 = @"https:\\www.google.com \n profile\trajan";
            Console.WriteLine(saying2);
            // If we have "" (double quotes) we need to wrap them in other double quotes
            string saying3 = @"https:\\www.google.com\""profile""\trajan";
            Console.ReadLine();


        }
    }
}
