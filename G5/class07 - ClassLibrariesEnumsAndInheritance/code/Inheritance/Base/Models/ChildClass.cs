using System;
using System.Collections.Generic;
using System.Text;

namespace Base.Models
{
    public class ChildClass : ParentClass
    {
        public int Age { get; set; }

        public ChildClass(string firstName, string lastName, int age) : base(firstName, lastName)
        {
            Age = age;
        }
    }
}
