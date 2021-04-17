using SEDC.CSharpOop.Class10.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.CSharpOop.Class10.Domain.Data
{
    public class UserRepo
    {
        public Admin GetAdminByEmail(string email)
        {
            Admin admin = InMemoryDatabase.Admins.First(admin => admin.Email == email);
            return admin;
        }

        public Student GetStudentByEmail(string email)
        {
            Student student = InMemoryDatabase.Students.First(student => student.Email == email);
            return student;
        }

        public Trainer GetTrainerByEmail(string email)
        {
            Trainer trainer = InMemoryDatabase.Trainers.First(trainer => trainer.Email == email);
            return trainer;
        }
    }
}
