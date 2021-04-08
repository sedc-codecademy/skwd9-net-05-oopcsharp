using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Cat : Animal
    {
        public string Lazyness { get; set; }

        public override void Eat() 
        {
            Console.WriteLine("You don't tell a Cat when to eat!");
        }

        public virtual void Meow() 
        {
            Console.WriteLine("Meow Meow");
        }

        // with : base() we are calling the parent constructor
        public Cat() : base("Cat")
        {
            Console.WriteLine("A new instance of the Cat is created by calling the parent constructor!");
        }
    }
}
