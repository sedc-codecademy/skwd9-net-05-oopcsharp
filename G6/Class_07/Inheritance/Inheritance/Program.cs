using Inheritance.Classes;
using Inheritance.Enums;
using System;
using OurClasses;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal dambo = new Animal()
            {
                Id = 2,
                Name = "Dambo",
                Type = AnimalTypes.Other
            };
            dambo.PrintInfo();
            dambo.Eat();
            Dog jango = new Dog()
            {
                Id = 1,
                Name = "Jango",
                Race = "Pudle"
            };
            // methods that dog inherits from animal
            jango.PrintInfo();
            jango.Eat();
            // method that is specific only for dog
            jango.Bark();

            Cat kitty = new Cat()
            {
                Id = 3,
                Name = "Kitty",
                Lazyness = "Very"
            };
            Console.WriteLine("-------------------------------------------------------------");
            //kitty.Meow();
            //kitty.PrintInfo();
            //kitty.Eat();
            Console.WriteLine(kitty.Type);

            Mouse mouse = new Mouse();

            // casting
            //int castedValue = (int)WeekDays.Tuesday;
            //int number = 5;
            //WeekDays tuesday = (WeekDays)number;
            //Console.WriteLine(tuesday);
            Console.ReadLine();

        }
    }
}
