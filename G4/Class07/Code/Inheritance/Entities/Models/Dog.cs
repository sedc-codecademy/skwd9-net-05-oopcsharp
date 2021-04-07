using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Entities.Models
{
    public class Dog : Animal
    {
        // property that is unique to the Dog class.  It has also all Animal properties { Id, Type, Name, IsHappy } 
        public string Breed { get; set; }

        // Constructor of Dog that will be called on every instance
        // The Animal Default c-tor is first called, then this one 
        public Dog()
        {
            IsHappy = true;
            Console.WriteLine("A new instance of Dog is created and also called the Default Parent Contructor");
        }

        // method that is unique to Dog class
        public void Bark()
        {
            Console.WriteLine(" WOOF! WOOF! ");
        }

        public void IsDogHappy()
        {
            Console.WriteLine(IsHappy ? "I am a happy doggo!" : "I am sad :(");
        }

    }
}
