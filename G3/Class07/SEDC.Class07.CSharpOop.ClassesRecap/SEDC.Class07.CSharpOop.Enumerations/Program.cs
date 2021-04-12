using SEDC.Class07.CSharpOop.Enumerations.Classes;
using System;


namespace SEDC.Class07.CSharpOop.Enumerations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Book newWorld = new Book("New World", "Dan Brown", BookGenre.Sci_Fi, 300, 7.50);
            newWorld.PrintBookInfo();
            Console.WriteLine($"The enum sci_fi is of type { newWorld.Genre.GetTypeCode()}");
            Console.WriteLine($"The enum of newWorld is {newWorld.Genre}");
            //Do not parse enums like this. This is just example
            //Console.WriteLine($"The number of the enum in background is {(int)newWorld.Genre}");
            Book cSharpInDepth = new Book("CShari in depth", "Robert Something", BookGenre.Biografy, 200, 10.5);
            string myCustomGenre = "Fittness";
            bool isMyCustomGenreValid = Enum.TryParse(myCustomGenre, out BookGenre genre);
            Console.WriteLine($"The {myCustomGenre} {isMyCustomGenreValid} exist");
            Console.WriteLine(genre);
            User damjan = new User();
            Console.ReadLine();
        }
    }
}
