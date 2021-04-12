using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Entities.Models
{
    public class Cat : Animal
    {
        // this is unique property to Cat. Cat has all properties of Animal
        public string Laziness { get; set; }

        // this constructor calls the Animal constructor that requires type param
        public Cat() : base("cat")
        {
            Console.WriteLine("A new instance of Cat is created by the parent c-tor that requires type parameter");
        }

        // unique method to Cat
        public void Meow()
        {
            Console.WriteLine("MEOW MEOW");
        }

        // override of a method that is inherited from the parent class
        public override void Eat()
        {
            // base.Eat(); - if you don't want to change
            Console.WriteLine("You don't tell a cat when to eat!!!");
        }


    }
}
