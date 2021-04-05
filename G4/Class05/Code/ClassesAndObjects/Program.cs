using System;

namespace ClassesAndObjects
{
    // access modifier / class keyword / Name of class
    public class Student
    {
        // CONSTRUCTOR
        // access modifier / Name of the constructor is the name of the class
        // default c-tor
        public Student()
        {
            Console.WriteLine("I am the very important constructor!!!");
        }

        // PROPERTIES
        // access modifier / value type / name of the property / get & set
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        private int Age { get; set; }



        // METHODS
        // access modifier / return type / Name of the method / (parameters)
        public void SayHello()
        {
            Console.WriteLine($"Hello, I am {FirstName} {LastName}.");
            HowOld(DateTime.Today);
            Console.WriteLine($"I am {Age} years old.");
        }

        private void HowOld(DateTime today)
        {
            if(today.Month < DateOfBirth.Month)
            {
                Age = today.Year - DateOfBirth.Year - 1;
            } else
            {
                Age = today.Year - DateOfBirth.Year;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // instantiate an object
            Student student01 = new Student();
            student01.FirstName = "Kristina";
            student01.LastName = "Spasevska";
            student01.DateOfBirth = new DateTime(1987, 3, 26);

            // we cannot access the property age here!!!
            //student01.Age = 34;
            //Console.WriteLine(student01.Age);

            Student student02 = new Student();
            student02.FirstName = "Panche";
            student02.LastName = "Manaskov";
            student02.DateOfBirth = new DateTime(1992, 12, 17);

            //Console.WriteLine(student01.FirstName);
            //student01.SayHello();
            //student02.SayHello();

            // keep students in an array
            Student[] students = new Student[2]
            {
                student01,
                student02
            };
            foreach (Student item in students)
            {
                item.SayHello();
            }

            Console.ReadLine();
        }
    }
}
