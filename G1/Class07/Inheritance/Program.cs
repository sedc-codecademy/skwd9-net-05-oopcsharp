using System;
using Inheritance.Classes;
using Inheritance.Enums;
using Models;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Animal cat = new Animal(1, "Garfield", "Cat");
            //Animal dog = new Animal(2, "Bark", "Dog");
            //Dog dog = new Dog();
            //dog.Id = 2;
            //dog.Name = "Bark";
            //dog.Type = "Dog";
            Dog dog = new Dog(2, "Bark", "Sharplaninec");
            Cat cat = new Cat("High", "High", 1, "Garfield");

            Console.WriteLine(dog.Eat());
            Console.WriteLine(cat.GetInfo());

            Console.WriteLine(dog.Bark());
            Console.WriteLine(cat.Meow());

            Tiger tiger = new Tiger("Low", "Medium", 3, "TigerName");
            Console.WriteLine(tiger.Meow());
            Console.WriteLine(cat.Eat());
            Console.WriteLine(tiger.Eat());


            //Demo ENUMS
            Human human = new Human("Risto", "Panchevski", new DateTime(1989, 7, 20), Days.Sun);
            Console.WriteLine(human.GetInfo());
        }
    }
}
