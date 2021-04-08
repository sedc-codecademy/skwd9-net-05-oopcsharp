using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Class07.CSharpOop.Inheretence.Domain.Classes
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Role Role { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
    }
}
