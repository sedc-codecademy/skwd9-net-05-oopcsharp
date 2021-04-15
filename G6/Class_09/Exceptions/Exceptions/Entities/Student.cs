using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions.Entities
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<Subject> Subjects { get; set; }
    }
}
