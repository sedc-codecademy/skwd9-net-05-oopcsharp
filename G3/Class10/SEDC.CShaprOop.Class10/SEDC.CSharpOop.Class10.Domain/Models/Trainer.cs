using SEDC.CSharpOop.Class10.Domain.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpOop.Class10.Domain.Models
{
    public class Trainer : User
    {
        public List<Subject> Subjects { get; set; }

        public Trainer(int id, string fname, string lname, string email, string password)
            : base(id, fname, lname, email, password, Role.Trainer)
        {
        }
    }
}
