using System;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstStatement = "Check your c:\\ drive";
            Console.WriteLine(firstStatement);
            string secondStatement = "We will have \"fair\" elections";
            Console.WriteLine(secondStatement);
            string thirdStatement = "The \\n sign means: new line";
            Console.WriteLine(thirdStatement);
            string statement1 = @"Check your c:\ drive";
            Console.WriteLine(statement1);
            string statement2 = @"We will have ""fair"" elections";
            Console.WriteLine(statement2);
            string statement3 = @"The \n sign means: new line";
            Console.WriteLine(statement3);
        }
    }
}
