using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpOop.Class06.ClassesApp.MyClasess
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        private long SSN { get; set; }

        public void Talk(string text)
        {
            Console.WriteLine($"The human named {Name} is saying: {text}");
        }
    }
}
