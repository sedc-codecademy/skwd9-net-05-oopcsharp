

using System;

namespace Inheritance.Classes
{
    public class Dog : Animal
    {
        public string Race { get; set; }

        public void Bark()
        {
            Console.WriteLine("Bark bark");
        }

        public void PrintName()
        {
            Console.WriteLine($"{Name}"); //public
        }

        public void PrintId()
        {
            Console.WriteLine($"{Id}"); //protected
        }

        //public void PrintPrivateProperty()
        //{
        //    Console.WriteLine($"{_privateProperty}"); //not allowed -> private
        //}

        //Default constructor of Animal will be called, because we are not explicitly calling an Animal's constructor
        public Dog()
        {
            Console.WriteLine("Dog's parameterless constructor");
        }

        //different signature from Eat method in Animal
        public void Eat()
        {
            Console.WriteLine("The dogs love to eat!");
        }

        public override void Eat(string food)
        {
            //base.Eat(food); -> Animal.Eat
            Console.Write($"The dog {Name} eats {food}");
        }

        //we explicitly tell which constructor from Animal will be called
        public Dog(string name, string color, string race) : base(name, color)
        {
            Race = race;
            Console.WriteLine("Dog's Constructor with parameters was called!");
        }
    }
}
