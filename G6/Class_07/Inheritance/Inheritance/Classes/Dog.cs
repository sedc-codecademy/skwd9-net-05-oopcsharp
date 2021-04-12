using Inheritance.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Classes
{
    // Dog inherits from Animal
    public class Dog : Animal
    {
        public Dog() : base(AnimalTypes.Dog)
        {
            Console.WriteLine("New instance of dog is created!");
        }
        // This property is uniqe for Dog
        public string Race { get; set; }

        // Method that is unique for Dog
        public void Bark()
        {
            Console.WriteLine("Af, af!");
        }


    }
}
