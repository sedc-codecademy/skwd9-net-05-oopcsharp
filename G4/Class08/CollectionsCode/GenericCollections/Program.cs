using System;
using System.Collections.Generic;

namespace GenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Generic Collections!");
            Console.WriteLine("----------- List ---------------");
            #region List

            // Creating a List
            List<string> sedcGroups = new List<string>() { "G1", "G2", "G3", "G4" };

            // Adding items to List
            sedcGroups.Add("G5");

            // Adding multiple elements
            sedcGroups.AddRange(new List<string>() { "G6", "G7", "G8" });

            foreach (string item in sedcGroups)
            {
                Console.Write($"{item} ");
            }

            sedcGroups.Remove("G7");

            Console.WriteLine($"The list has {sedcGroups.Count} elements.");

            // List with custom types
            List<Car> cars = new List<Car>();
            cars.Add(new Car() { Model = "BMW" });
            cars.Add(new Car() { Model = "Audi" });

            foreach (Car item in cars)
            {
                Console.WriteLine(item.Model);
            }
            Console.WriteLine("--------------------------");
            #endregion

            #region Dictionary
            Console.WriteLine("----------- Dictionary ---------------");
            // Creating a Dictionary
            Dictionary<string, int> examPoints = new Dictionary<string, int>()
            {
                { "John", 70 },
                { "Bob", 45 },
                { "Jack", 100 }
            };

            // Adding elements
            // KEY HAS TO BE UNIQUE!!!
            // the same key
            //examPoints.Add("John", 90);

            examPoints.Add("Kristina", 12);
            examPoints.Add("Pane", 100);

            // Removing an item - enter the Key only
            examPoints.Remove("John");

            foreach (var item in examPoints)
            {
                Console.WriteLine($"The student {item.Key} has {item.Value} points.");
                Console.WriteLine(item.Value >= 50 ? "Passed :)" : "Failed :(");
                Console.WriteLine("+++++++++++++++");
            }

            Dictionary<string, Car> carsWithPlates = new Dictionary<string, Car>();

            Car car01 = new Car() { Model = "Ford" };
            Car car02 = new Car() { Model = "Opel" };

            carsWithPlates.Add("SK1111AA", car01);
            carsWithPlates.Add("VE2222BB", car02);

            // ContainsKey check if a record with that Key is present in the Dictionary - returns True / False
            Console.WriteLine(carsWithPlates.ContainsKey("SK1122AA"));

            // we can access an element's Value with a given Key
            Car result = carsWithPlates["SK1111AA"];

            // it will throw an exception
            //Car result = carsWithPlates["SK1234AA"];

            // it's valid to remove an item that is with non-existant Key (?!?)
            carsWithPlates.Remove("RTJKVCH");
            Console.WriteLine(result.Model);

            Console.WriteLine($"Cars with plates count: {carsWithPlates.Count}");
            Console.WriteLine("--------------------------");
            #endregion

            #region Queue
            Console.WriteLine("----------- Queue ---------------");
            // creating a Queue
            Queue<string> students = new Queue<string>();

            // adding elements
            students.Enqueue("Leart");
            students.Enqueue("Ivan");
            students.Enqueue("Jana");
            students.Enqueue("Ceca");
            students.Enqueue("Nikola");

            // Peek()  checks what is the next element
            Console.WriteLine(students.Peek());

            // remove an item
            students.Dequeue();
            // remove and store in variable
            //string firstStudent = students.Dequeue();
            Console.WriteLine(students.Peek());

            foreach (var item in students)
            {
                Console.WriteLine(item);
            }

            // FIFO order - First In First Out
            #endregion


            #region Stack
            Console.WriteLine("----------- Stack ---------------");
            // creating a Stack
            Stack<string> pancakes = new Stack<string>();

            // adding an element
            pancakes.Push("pancake 01");
            pancakes.Push("pancake 02");
            pancakes.Push("pancake 03");

            Console.WriteLine(pancakes.Peek());

            // remove an item
            pancakes.Pop();

            Console.WriteLine(pancakes.Peek());

            #endregion
            Console.ReadLine();
        }
    }
}
