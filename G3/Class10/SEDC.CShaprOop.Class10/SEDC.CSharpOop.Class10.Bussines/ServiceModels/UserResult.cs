using SEDC.CSharpOop.Class10.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpOop.Class10.Bussines.ServiceModels
{
    public class UserResult
    {
        public Admin Admin { get; set; }
        public Student Student { get; set; }
        public Trainer Trainer { get; set; }
        public bool IsLoggedIn { get; set; }
    }
}
