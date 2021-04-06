using SEDC.CSharpOop.Class06.ClassesApp.MyClasess;
using System;

namespace SEDC.CSharpOop.Class06.ClassesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Trajan";
            person.Age = 33;
            // person.SSN = 1231231; // we cant access this becouse it is private;
            person.Talk("Hello");

            Console.WriteLine($"Hello my name is {person.Name} and im {person.Age} years old");


            Console.ReadLine();
        }
    }
}
