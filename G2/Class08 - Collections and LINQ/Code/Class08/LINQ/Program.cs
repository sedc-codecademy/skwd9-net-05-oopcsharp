using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dog> dogs = new List<Dog>()
            {
                new Dog(){Name = "Sparky", Age = 2},
                new Dog(){Name = "Butch", Age = 1},
                new Dog(){Name = "Zoe", Age = 3},
                new Dog(){Name = "Sia", Age = 1},
                new Dog(){Name = "William", Age = 4},
                new Dog(){Name = "Billy", Age = 1},
                new Dog(){Name = "Buck", Age = 2}
            };
            //All dogs whose name is longer than 3 characters
            List<Dog> longerThanThree = dogs.Where(d => d.Name.Length > 3).ToList();
            foreach(Dog dog in longerThanThree)
            {
                Console.WriteLine(dog.Name);
            }
            Console.WriteLine("============");
            foreach (Dog dog in dogs)
            {
                Console.WriteLine(dog.Name);
            }

           //All dogs of age 1 that have a name that starts with B
            List<Dog> ageOneStartingWithB = dogs
                .Where(x => x.Age == 1)
                .Where(x => x.Name.StartsWith("B"))
                .ToList();
            Console.WriteLine("============");
            foreach (Dog dog in ageOneStartingWithB)
            {
                Console.WriteLine(dog.Name);
            }
            List<Dog> ageOneStartingWithB2 = dogs.Where(x => x.Age == 1 && x.Name.StartsWith("B")).ToList();
            Console.WriteLine("============");
            foreach (Dog dog in ageOneStartingWithB2)
            {
                Console.WriteLine(dog.Name);
            }

            //SELECT
            //get all dogs' names
            List<string> dogsNames = dogs.Select(x => x.Name).ToList();
            Console.WriteLine("============");
            foreach (string name in dogsNames)
            {
                Console.WriteLine(name);
            }

            //get description for every dog whose age is 2
            List<string> descriptions = dogs.Where(x => x.Age == 2)
                .Select(x => $"{x.Name} {x.Age}")
                .ToList();
            Console.WriteLine("============");
            foreach (string description in descriptions)
            {
                Console.WriteLine(description);
            }

            List<Dog> filteredDogs = dogs.Where(x => x.Name.StartsWith("B")).Select(x => x).ToList();

            //FIRST
            // Dog dogAged5 = dogs.First(x => x.Age == 5); - EXCEPTION
            //get first dog aged 5 or return null
            Dog dogAged5 = dogs.FirstOrDefault(x => x.Age == 5);
            //get first dog aged 1 or return null
            Dog dogAged1 = dogs.FirstOrDefault(x => x.Age == 1);

            int aged2 = dogs.Count(x => x.Age == 2);
            Console.ReadLine();
        }
    }
}
