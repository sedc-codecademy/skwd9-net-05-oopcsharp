using System;
using Classes.MyClasses;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Viktor";
            person.Age = 31;

            person.Talk("Hello there!");

            Person person2 = new Person("Angela", 25);
            person2.Talk("Hi there!");
            
            Console.ReadLine();
        }
    }
}
