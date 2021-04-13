using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // Non Generic collections => we must using System.Collections namespace
            // ArrayList
            // mixed (accepts all types and does not have constraints on number of elements like arrays have)
            ArrayList list = new ArrayList() {
                "Bob",
                22,
                true,
                22.5,
                new string[] 
                { 
                    "Hi",
                    "Bye" 
                } 
            };
            
            // add new element at the end of the arraylist
            list.Add(100);
            list.Add(false);
            list.Add("Jane");
            // remove the element with the value that we pass on Remove method
            // list.Remove("Bob123");

            // we pass index of the element that we want to remove
            list.RemoveAt(4);
            // Console.WriteLine(list.Count);
            // Console.WriteLine(list[2]);
            // IterateCollection(list);


            // Generic collections => we must using System.Collections.Generic namespace
            // Dictionary ( Works on key/value pair system. This system gives us the option to get values from collextion by some key)

            Dictionary<string, int> phoneBook = new Dictionary<string, int>()
            {
                {"Jane", 999999999 },
                {"Sonny", 128371289 }
            };
            phoneBook.Add("John", 077777777);
            phoneBook.Add("Bob", 0788888888);

            // Console.WriteLine(phoneBook["Bob"]);
            bool contains = phoneBook.ContainsKey("John1");
            if (contains)
                Console.WriteLine(phoneBook["John1"]);
            //Console.WriteLine($"The number of elements in phoneBook is { phoneBook.Count }");
            //IterateCollection(phoneBook);
            bool getSuccess = phoneBook.TryGetValue("Sonny1", out int sonnyNumber);
            // Console.WriteLine(sonnyNumber); ;

            // LIST
            List<int> integerList = new List<int>() { 1, 2, 3, 4, 5 };
            integerList.Add(6);
            integerList.Add(7);

            //integerList.Remove(7);
            //integerList.RemoveAt(1);
            // Console.WriteLine(integerList[3]);
            // Console.WriteLine($"The number of elements in integerList is { integerList.Count }");
            /// IterateCollection(integerList);

            // QUEUE (FIRST IN FIRST OUT)
            Queue<int> intQueue = new Queue<int>();
            // adding item to the Queue
            intQueue.Enqueue(4);
            intQueue.Enqueue(5);
            intQueue.Enqueue(6);
            // Remove first item from the queue
            int firstMemeberOut = intQueue.Dequeue(); // get the first element out of the queue
            // Console.WriteLine(firstMemeberOut);
            int firstElement = intQueue.Peek(); // get the value of the first element
            // Console.WriteLine(firstElement);
            // Console.WriteLine(intQueue.Count);
            // IterateCollection(intQueue);

            // STACK (LAST IN FIRST OUT)
            Stack<string> ourStack = new Stack<string>();
            ourStack.Push("John");
            ourStack.Push("Bob");
            ourStack.Push("Jane");

            string lastMemeberOut = ourStack.Pop(); // get the last element out of the stack
            //Console.WriteLine(lastMemeberOut);
            //Console.WriteLine("------------------------------------------");
            //IterateCollection(ourStack);
            Console.WriteLine(ourStack.Count);

            Console.ReadLine();
        }

        // Method that accepts anything iterable as a parametar
        static void IterateCollection(IEnumerable collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
