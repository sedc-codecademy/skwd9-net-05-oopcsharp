using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Entities.Models
{
    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        protected bool IsHappy { get; set; }

        public Animal()
        {
            Console.WriteLine("This is the Default Constructor of Animal");
        }

        public Animal(string type)
        {
            Type = type;
            Console.WriteLine("This is the Type Constructor of Animal");
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Id: {Id}, Type: {Type}, Animal Name: {Name}");
        }

        public virtual void Eat()
        {
            Console.WriteLine($"The {Type} named {Name} is eating!");
        }

        // this is an example of an method overload
        public virtual void Eat(string food)
        {
            Console.WriteLine($"{Name} is eating {food}");
        }
    }
}
