using System;

namespace Classes.MyClasses // this is the address of this class
{
    public class Person
    {
        // Properties must have type, access modifiers and get/set
        // shortcut for creating a property "prop + 2x tab"
        public string Name { get; set; }
        public int Age { get; set; }
        private long SSN { get; set; } // private properties can be accessedd only in the
                                       // class where are created

        // shortcut for creating a constructor "ctor + 2x tab"
        public Person()
        {
            SSN = GenerateSSN();
        }

        // second constructor, will be called when name and age will be provided while instaniating a new object.
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            SSN = GenerateSSN();
        }

        private long GenerateSSN() 
        {
            long ssn = new Random().Next(100000, 900000);
            return ssn;
        }

        public void Talk(string text) 
        {
            Console.WriteLine($"The human named {Name} (SSN: {SSN}) is saying: {text}");
        }
    }
}
