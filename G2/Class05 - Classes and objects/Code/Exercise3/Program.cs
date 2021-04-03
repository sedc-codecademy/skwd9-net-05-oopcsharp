using Exercise3.Classes;
using System;

namespace Exercise3
{
    class Program
    {
        static Student FindStudent(string name, Student[] studentsArray)
        {
            foreach(Student student in studentsArray)
            {
                if(student.FirstName.ToLower() == name.ToLower())
                {
                    return student;
                }
            }
            return null;
        }
		static void Main(string[] args)
        {
            Student[] students = new Student[]
            {
                new Student("Bojan", "G2", "Web Development"),
                new Student("Jovana", "G2", "Web Design"),
                new Student("Stefan", "G3", "QA"),
                new Student("Bojana", "G5", "Networks"),
                new Student("Aleksandar", "G3", "Web Design")
            };

            Console.WriteLine("Enter name to fina a student:");
            string name = Console.ReadLine();

            Student foundStudent = FindStudent(name, students);
            if(foundStudent == null)
            {
                Console.WriteLine("The student was not found");
            }
            else
            {
                Console.WriteLine($"We found the student: {foundStudent.FirstName} {foundStudent.Academy}");
            }

            Console.ReadLine();
        }
    }
}
