using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array
            string[] stringsInArray = new string[4];
            string[] stringsInArray2 = new string[] { "Hello", "World", "!" };
            GoTroughtColletion(stringsInArray2, "Array");
            Console.WriteLine("Length: " + stringsInArray2.Length);

            //ArrayList - Accepts all types and not have constraint on number of elements (same as JS array)
            ArrayList arrayList = new ArrayList() { "Hello", 2, true };
            arrayList.Add("World");
            arrayList.Add(stringsInArray2);
            arrayList.Remove("Hello");
            GoTroughtColletion(arrayList, "ArrayList");
            Console.WriteLine("Length: " + arrayList.Count);

            //Lists - Has designated type and does not have constraint on number of elements
            List<int> listOfInt = new List<int> { 1,3,5 };
            listOfInt.Add(25);
            listOfInt.Remove(3);
            Console.WriteLine("Length: " + listOfInt.Count);
            GoTroughtColletion(listOfInt, "List");

            List<Human> humans = new List<Human>();
            var human1 = new Human
            {
                Name = "Viktor"
            };
            humans.Add(human1);

            Console.ReadLine();
        }

        public static void GoTroughtColletion(IEnumerable collection, string name) 
        {
            Console.WriteLine("Collection {0} items:", name);
            foreach (var item in collection)
            {
                Console.Write("{0}  ", item);
            }
            Console.WriteLine("======");
        }

        public class Human 
        {
            public string Name { get; set; }
        }
    }
}
