using Inheritance.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Classes
{
    public class Animal
    {
        public Animal()
        {
            Console.WriteLine("Animal constructor was called!");
        }
        public Animal(AnimalTypes animalType)
        {
            Type = animalType;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public AnimalTypes Type { get; set; }


        public void PrintInfo()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Animal: {Type}");
        }

        public virtual void Eat()
        {
            Console.WriteLine($"The {Type} animal named {Name} is now eating!");
        }
    }
}
