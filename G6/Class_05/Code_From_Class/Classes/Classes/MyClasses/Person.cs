using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.MyClasses // this is the address of this class
{
    class Person
    {
        public Person()
        {
            SSN = GenerateSSN();
        }
        //public Person(string name)
        //{
        //    Name = name;
        //}
        //public Person(int age)
        //{
        //    Age = age;
        //}
        // Properties must have type, access modifier, get/set
        public Person(string whatever, int age)
        {
            Name = whatever;
            Age = age;
            SSN = GenerateSSN();
        }
        public string Name { get; set; }
        public int Age { get; set; }
        private long SSN { get; set; }

        // access modifier, return type, name of the method
        public void Talk(string words)
        {
            Console.WriteLine($"The human named {Name} with SSN: {SSN} is saying: {words}");
        }

        private long GenerateSSN()
        {
            return new Random().Next(100000, 9999999);
        }
    }
}
