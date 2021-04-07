using Inheritance.Entities.Models;
using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inheritance in C#!");
            Console.WriteLine("------------------------------");

            Animal dumbo = new Animal()
            {
                Id = 1,
                Name = "Dumbo",
                Type = "elephant"
                // IsHappy = true - we can't access it here it's protected
            };
            dumbo.PrintInfo();
            dumbo.Eat();
            Console.WriteLine("------------------------------");
            Dog vele = new Dog()
            {
                Id = 2,
                Type = "dog",
                Name = "Vele",
                Breed = "dzukela"
            };
            vele.PrintInfo();
            vele.Eat();
            vele.Bark();
            vele.IsDogHappy();
            Console.WriteLine("------------------------------");
            Cat garfield = new Cat()
            {
                Id = 3,
                Name = "Garfield",
                Laziness = "very much"
            };
            // we don't tell the type
            garfield.PrintInfo();
            garfield.Eat();
            // another overload is
            garfield.Eat("fish");
            garfield.Meow();
            Console.WriteLine("------------------------------");

            #region Enums
            // Enumerators
            Console.WriteLine(DayOfWeek.Tuesday);
            DiscountDay dayOne = new DiscountDay()
            {
                Discount = 10,
                Day = DayOfWeek.Monday
            };
            Console.WriteLine($"On {dayOne.Day} you would have {dayOne.Discount}% discount");
            int dayOneInteger = (int)dayOne.Day;
            Console.WriteLine(dayOneInteger);

            // casting into integer
            DateTime today = DateTime.Now;
            // casting into integer
            int dayWeekToday = (int)today.DayOfWeek;
            Console.WriteLine(dayWeekToday);
            #endregion
            Console.ReadLine();
        }
    }
}
