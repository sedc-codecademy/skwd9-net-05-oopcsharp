using System;
using Models;

namespace SecondExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human2 = new Human("test", "test", DateTime.Now, Days.Fri);
            Console.WriteLine(human2.GetInfo());
        }
    }
}
