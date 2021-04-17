using System;
using System.Collections.Generic;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student()
            {
                Id = 1,
                Name = "Viktor",
                HasPat = true
            };

            Student student2 = new Student()
            {
                Id = 2,
                Name = "Anglea",
                HasPat = false
            };

            Student student3 = new Student()
            {
                Id = 3,
                Name = "Robert",
                HasPat = true
            };

            Student student4 = new Student()
            {
                Id = 4,
                Name = "Anja",
                HasPat = true
            };

            List<Student> students = new List<Student>() { student1, student2, student3, student4 };

            int petCounter = 0;

            foreach (var student in students)
            {
                if (student.HasPat) 
                {
                    petCounter++;
                }
            }

            Console.WriteLine(petCounter);


        }
    }

    // This is same as creating a new class in the solution, its a bad practise, and its used only for demo purposes
    public class Student 
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        public bool HasPat { get; set; }
    }

}
