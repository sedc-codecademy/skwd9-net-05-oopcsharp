using Inheritance.Classes;
using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            Animal animal = new Animal();
            //Console.WriteLine(animal.Id);
            //Console.WriteLine(animal._privateProperty);

            Dog dog = new Dog("Barnie", "Brown", "Labrador");
            Console.WriteLine(dog.Name);
            //Name property is public, inherited from Animal, also belongs to Dog
            dog.Name = "Sparkie";
            Console.WriteLine(dog.Name);
            // Console.WriteLine(dog._privateProperty); -> private property
            // Console.WriteLine(dog.Id); _> protectd property

            dog.PrintId();
            //inherited method from Animal
            dog.PrintBasicInfo();

            Cat cat = new Cat() { Name = "Garfield", Color = "Orange", IsLazy = true };
            cat.PrintBasicInfo();
            //method from Animal
            dog.Eat("Meat");
            //method from Dog
            dog.Eat();
            //method from Cat
            cat.Eat("Fish");

            Console.ReadLine();
        }
    }
}
