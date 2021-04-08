using System;
using Models.Models;
using Models.Enums;

namespace ClassLibrariesAndEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human("Viktor", "Jakovlev", DateTime.Now.AddMonths(5), Days.Monday);
            Human human2 = new Human("Viktor2", "Jakovlev2", DateTime.Now.AddMonths(3), Days.Sunday);

            Console.WriteLine(human.GetInfo());
            Console.WriteLine(human2.GetInfo());

            Console.ReadLine();
        }
    }
}
