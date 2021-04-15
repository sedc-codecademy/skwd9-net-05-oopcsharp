using LINQ.models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // Data for LINQ manipulation
            List<Dog> dogs = new List<Dog>()
            {
                new Dog(){ Name = "Sparky", Age = 2 },
                new Dog(){ Name = "Butch", Age = 1},
                new Dog(){ Name = "Zoe", Age = 3},
                new Dog(){ Name = "Sia", Age = 1},
                new Dog(){ Name = "William", Age = 4},
                new Dog(){ Name = "Billy", Age = 1},
                new Dog(){ Name = "Buck", Age = 2}
            };

            // .Where() - (filter in JS)

            // All dogs with name longer then 3 letters
            // let filteredDogs = dogs.filter(dog => dog.name.length > 3)
            List<Dog> lognerThen3 = dogs.Where(dog => dog.Name.Length > 3).ToList();

            // All dogs that have a name starting woth letter S
            List<Dog> startsWithS = dogs.Where(dog => dog.Name.StartsWith("S")).ToList();

            // First dog that is of age 1 and have a name that starts with B
            Dog Age1StartsWithB = dogs.Where(dogs => dogs.Age == 1 && dogs.Name.StartsWith("B")).First();


            // .Select() - (map in JS)

            // All names of dogs
            List<string> dogNames = dogs.Select(dog => dog.Name).ToList();

            // All ages of dogs
            List<int> dogAges = dogs.Select(dog => dog.Age).ToList();

            // All names of dogs that are the age of 2
            var dogNamesWithAgeOf2 = dogs.Where(dog => dog.Age == 2).Select(dog => dog.Name).ToList();

            // .First() and .Last()
            Dog firstDog = dogs.First();
            Dog lastDog = dogs.Last();

            // .Agregate() - (reduce in JS)
            int TottalAgeOfDogs = dogs.Aggregate(0, (acc, dog) => acc + dog.Age);

            // .ForEach() - same as forEach() in JS, NOT PART OF A LINQ!
            dogs.ForEach(dog => 
            {
                Console.WriteLine(dog.Name);
            });

        }
    }
}
