using System;
using System.Collections.Generic;
using System.Text;

namespace ClassExercises
{
    public class Human
    {
        public Human()
        {

        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        
        public void GetPersonStats() {
            Console.WriteLine($"Hello, I'm {FirstName} {LastName} and I'm {Age} years old.");
        }
    }
}
