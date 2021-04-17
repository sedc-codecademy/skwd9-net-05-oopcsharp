using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqQuering
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Initial Linq
            //Console.WriteLine("----------- Initial list ----------");
            //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };
            //numbers.ForEach(num => Console.WriteLine(num));

            //// Select
            //Console.WriteLine("----------- Select ----------");
            //List<int> addOneToNumbers = numbers
            //                      .Select((num, index) => num + 1)
            //                      .ToList();
            ////foreach (int item in addOneToNumbers)
            ////{
            ////    Console.WriteLine(item);
            ////}

            //// even lazier way to loop through all elements
            //addOneToNumbers.ForEach(num => Console.WriteLine(num));

            //// Where
            //Console.WriteLine("----------- Where ----------");
            //List<int> greaterThanThree = numbers
            //                        .Where(num => num >= 3)
            //                        .ToList();
            //greaterThanThree.ForEach(num => Console.WriteLine(num));

            //// First
            //Console.WriteLine("----------- First ----------");
            //int firstElement = numbers
            //                    .First();
            //Console.WriteLine(firstElement);

            //// Last
            //Console.WriteLine("----------- Last ----------");
            //int lastElement = numbers
            //                    .Last();
            //Console.WriteLine(lastElement);
            #endregion

            #region Chained Linq
            // Data for LINQ manipulation
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

            // All dogs with name longer than 3 characters
            List<Dog> nameLongerThan3 = dogs
                                    .Where(x => x.Name.Length > 3)
                                    .ToList();
            //nameLongerThan3.ForEach(x => Console.WriteLine(x.Name));

            // All dogs with name starting with S
            List<Dog> nameStartsWithS = dogs
                                        //.Where(x => x.Name.ToCharArray()[0] == 'S')
                                        .Where(x => x.Name.StartsWith("S"))
                                        .ToList();
            //nameStartsWithS.ForEach(x => Console.WriteLine(x.Name));

            // First dog that is of age 1 and has a name that starts with B
            Dog dogAge1NameB = dogs
                                .Where(x => x.Age == 1)
                                .Where(x => x.Name.StartsWith("B"))
                                .First();
            //Console.WriteLine(dogAge1NameB.Name);
           // quering returned two results, but First returns the first ONLY

            Dog dogAge1NameBDefault = dogs
                                .Where(x => x.Age == 1)
                                .Where(x => x.Name.StartsWith("R"))
                                .FirstOrDefault();
            // FirstOrDefault returns null if it doesn't find any result from the quering
            //Console.WriteLine(dogAge1NameBDefault == null ? "No such dog" : dogAge1NameBDefault.Name);

            // All names of dogs
            List<string> namesOfDogs = dogs
                                .Select(x => x.Name)
                                .ToList();
            //namesOfDogs.ForEach(x => Console.WriteLine(x));


            // All dogs ages
            List<int> agesOfDogs = dogs
                                .Select(x => x.Age)
                                .ToList();
            //agesOfDogs.ForEach(x => Console.WriteLine(x));

            // All names of dogs of age 2
            List<string> namesOfDogsAge2 = dogs
                                    .Where(x => x.Age == 2)
                                    .Select(x => x.Name)
                                    .ToList();
            namesOfDogsAge2.ForEach(x => Console.WriteLine(x));
            #endregion
            Console.ReadLine();
        }
    }
}
