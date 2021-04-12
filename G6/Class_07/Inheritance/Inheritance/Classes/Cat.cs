using Inheritance.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Classes
{
    public class Cat : Animal
    {
        public Cat() : base(AnimalTypes.Cat)
        {
            Console.WriteLine("Cat was created!");
        }
        public string Lazyness { get; set; }

        public void Meow()
        {
            Console.WriteLine("Meow, meow!");
        }
        public override void Eat()
        {
            base.Eat();
            Console.WriteLine("It is eating fish actually");
        }
    }
}
