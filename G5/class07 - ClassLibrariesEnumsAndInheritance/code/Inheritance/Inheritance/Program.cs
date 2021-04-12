using System;
using Entities;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal()
            {
                Id = 1,
                Name = "Ben",
                Type = "Dog",

            };

            Dog majlo = new Dog()
            {
                Id = 2,
                Name = "Majlo",
                Type = "Dog",
                Breed = "Husky"
            };

            Cat garfild = new Cat()
            {
                Id = 3,
                Name = "Garfild",
                Lazyness = "Very"
            };

            Tiger tiger = new Tiger()
            {
                Id = 4,
                Name = "Tiger",
                Lazyness = "Non",
            };

            animal.Eat();
            majlo.Eat();
            garfild.Eat();
            garfild.Meow();
            tiger.Eat();
            tiger.Meow();
            tiger.PrintInfo();

            Console.ReadLine();
        }
    }
}
