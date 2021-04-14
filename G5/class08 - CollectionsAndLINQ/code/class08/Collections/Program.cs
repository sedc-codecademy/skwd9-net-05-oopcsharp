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

            //Dictionary - Works with key/valye pair system. This system gives us the functionality to get the values from a collection by some KEY!
            Dictionary<string, string> dictionaryOne = new Dictionary<string, string>();
            dictionaryOne.Add("song1", "songName1");
            dictionaryOne.Add("song2", "songName2");
            dictionaryOne.Add("song3", "songName3");
            Console.WriteLine(dictionaryOne["song1"]);

            Console.WriteLine("======");
            foreach (var item in dictionaryOne)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
            Console.WriteLine("======");

            //creating and initializing a Dictionary
            Dictionary<int, string> dictionaryTwo = new Dictionary<int, string> 
            {
                {1, "Hello" },
                {2, "World" },
                {7, "!" }
            };
            Console.WriteLine(dictionaryTwo[7]);
            Console.WriteLine("Length:" + dictionaryTwo.Count);
            GoTroughtColletion(dictionaryOne, "Dictionary");


            // Queue - First in first out 
            Queue<int> someQueue = new Queue<int>();
            someQueue.Enqueue(25);
            someQueue.Enqueue(13);
            someQueue.Enqueue(2);
            someQueue.Enqueue(44);
            GoTroughtColletion(someQueue, "Queue");
            someQueue.Dequeue();
            GoTroughtColletion(someQueue, "Queue - after Deque()");
            someQueue.Dequeue();
            GoTroughtColletion(someQueue, "Queue - after Deque1()");
            someQueue.Enqueue(125);
            GoTroughtColletion(someQueue, "Queue");
            Console.WriteLine(someQueue.Peek());
            Console.WriteLine("Length: " + someQueue.Count);

            // Stack - Last in first out
            Stack<string> someStack = new Stack<string>();
            someStack.Push("Viktor");
            someStack.Push("Angela");
            someStack.Push("Robert");
            GoTroughtColletion(someStack, "Stack");
            someStack.Pop();
            GoTroughtColletion(someStack, "Stack");
            someStack.Push("Igor");
            GoTroughtColletion(someStack, "Stack");
            someStack.Pop();
            GoTroughtColletion(someStack, "Stack");
            Console.WriteLine(someStack.Peek());
            Console.WriteLine("Length: " + someStack.Count);

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
