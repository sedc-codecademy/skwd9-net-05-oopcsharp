using SEDC.CSharpOop.Class10.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpOop.Class10.Domain
{
    public static class InMemoryDatabase
    {
        public static List<Admin> Admins { get; set; }
        public static List<Trainer> Trainers { get; set; }
        public static List<Student> Students { get; set; }

        static InMemoryDatabase()
        {
            Admins = GenerateAdmins();
            Trainers = GenerateTrainers();
            Students = GenerateStudents();
        }

        private static List<Student> GenerateStudents()
        {
            List<Subject> subjects = new List<Subject>
            {
                new Subject() { Name = "c# basic",
                    IsOptional = false,
                    NumberOfClasses = 10,
                    EndOn = new DateTime(2021, 04, 20),
                    StartOn =  new DateTime(2021, 04, 01)},
                new Subject() { Name = "c# advanced",
                    IsOptional = false,
                    NumberOfClasses = 10,
                    EndOn = new DateTime(2021, 05, 20),
                    StartOn =  new DateTime(2021, 05, 01)},
                new Subject() { Name = "javascript advanced",
                    IsOptional = false,
                    NumberOfClasses = 10,
                    EndOn = new DateTime(2021, 03, 20),
                    StartOn =  new DateTime(2021, 03, 01)},
                new Subject() { Name = "javascript basic",
                    IsOptional = false,
                    NumberOfClasses = 10,
                    EndOn = new DateTime(2021, 02, 20),
                    StartOn =  new DateTime(2021, 02, 01)},
                new Subject() { Name = "html",
                    IsOptional = false,
                    NumberOfClasses = 10,
                    EndOn = new DateTime(2021, 01, 20),
                    StartOn =  new DateTime(2021, 01, 01)},
                new Subject() { Name = "css",
                    IsOptional = false,
                    NumberOfClasses = 10,
                    EndOn = new DateTime(2020, 12, 20),
                    StartOn =  new DateTime(2020, 12, 01)},
            };

            List<Student> listOfStudents = new List<Student>
            {
                new Student(1, "Andjela", "Mitkova", "andmit@mail.com", "123asd") { Subjects = new List<Subject> { subjects[0], subjects[1], subjects[4] } },
                new Student(2, "Angel", "Jordanovski", "andjor@mail.com", "123asd") { Subjects = new List<Subject> { subjects[1], subjects[0], subjects[2] } },
                new Student(3, "Biljana", "Radevska", "bilrad@mail.com", "123asd") { Subjects = new List<Subject> { subjects[2], subjects[3], subjects[4] } },
                new Student(4, "Filip", "Belevski", "filbel@mail.com", "123asd") { Subjects = new List<Subject> { subjects[3], subjects[4], subjects[1] } },
                new Student(5, "Goran", "Stojanovski", "gorsto@mail.com", "123asd") { Subjects = new List<Subject> { subjects[2], subjects[3], subjects[4] } },
                new Student(6, "Igor", "Tarchugovski", "igotar@mail.com", "123asd") { Subjects = new List<Subject> { subjects[1], subjects[3], subjects[4] } },
                new Student(7, "Kristina", "Lazarovska", "krilar@mail.com", "123asd") { Subjects = new List<Subject> { subjects[2], subjects[3], subjects[1] } },
            };

            return listOfStudents;
        }

        private static List<Trainer> GenerateTrainers()
        {
            List<Trainer> listOfTrainer = new List<Trainer>
            {
                new Trainer(1, "Trajan", "Stevkovski", "traste@mail.com", "123asd"),
                new Trainer(2, "Damjan", "Stojanovski", "damsto@mail.com", "123asd"),
            };

            return listOfTrainer;
        }

        private static List<Admin> GenerateAdmins()
        {
            List<Admin> listOfAdmins = new List<Admin>
            {
                new Admin(1, "admin", "admin", "admin@mail.com", "123asd")
            };

            return listOfAdmins;
        }
    }
}
