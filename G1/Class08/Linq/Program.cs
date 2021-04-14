using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Sockets;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student("Aleksandar", "Panovski", 29, "Skopje"),
                new Student("Aleksandar", "Planic", 30, "Belgrad"),
                new Student("Darko", "Milenkovski", 28, "Skopje"),
                new Student("Dejan", "Stojkovski", 18, "Ohrid"),
                new Student("Goran", "Turundzov", 20, "Veles")
            };

            List<Student> studentsBetween18And25 = students.Where(student => student.Age >= 18 && student.Age <= 25).ToList();
            //List<Student> studentsThatContainAinTheSurname =
            //    students.Where(student => student.LastName.Contains("p") || student.LastName.Contains("P")).ToList();
            List<Student> studentsThatContainAinTheSurname =
                students.Where(student => student.LastName.Contains("p", StringComparison.InvariantCultureIgnoreCase)).ToList();
            List<Student> studentsWithNameAleksandarUnder30 =
                students.Where(x => x.FirstName == "Aleksandar" && x.Age < 30).ToList();


            //List<Student> filterStudents = (from student in students
            //                                where student.Age < 30 && student.FirstName == "Aleksandar"
            //                                select student)
            //                                .ToList();

            List<int> numbers = new List<int>() {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            List<int> evenNumbers = numbers.Where(x => x % 2 == 0).ToList();

            List<string> studentsFullName = students.Select(x => $"{x.FirstName} {x.LastName}").ToList();
            List<int> increasedNumbers = numbers.Select(x => x + 5).ToList();


            List<string> studentsFullNameFilter = students.Where(x => x.Age <= 20).Select(x => $"{x.FirstName} {x.LastName}").ToList();


            List<StudentsInfoModel> studentsInfo =
                students.Select(x => new StudentsInfoModel($"{x.FirstName} {x.LastName}", x.Age)).ToList();

            //Student firstStudent = students.First();
            //Student lastStudent = students.Last();


            Student firstOrDefaultStudent = students.FirstOrDefault();
            Student lastOrDefaultStudent = students.LastOrDefault();

            List<Invoice> invoices = new List<Invoice>()
            {
                new Invoice("EVN", new DateTime(2021, 3, 20), 1500),
                new Invoice("EVN", new DateTime(2021, 4, 20), 2300),
                new Invoice("Vodovod", new DateTime(2021, 3, 16), 500),
                new Invoice("Vodovod", new DateTime(2020, 4, 16), 600)
            };

            //List<Invoice> marchInvoices = invoices.Where(x => x.DueDate.Month == 3).ToList();
            //Invoice firstInvoiceInMarch = marchInvoices.FirstOrDefault();

            //Invoice firstInvoiceInMarch = invoices.Where(x => x.DueDate.Month == 3).FirstOrDefault();

            Invoice firstInvoiceInMarch = invoices.FirstOrDefault(x => x.DueDate.Month == 3);

            Invoice oldestInvoice = invoices.OrderBy(x => x.DueDate).FirstOrDefault();

            if (invoices.Any(x => x.Company == "BEG"))
            {
                Console.WriteLine("You have invoice from Vodovod");
            }

            if (invoices.All(x => x.DueDate.Year == 2021))
            {
                Console.WriteLine("All your invoices are for 2021");
            }
        }
    }
}
