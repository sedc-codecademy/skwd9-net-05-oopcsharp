﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void iterateCollection(IEnumerable collection)
        {
            foreach(var item in collection){
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            //Dictionary ( Works on Key/Value pair system. This system gives us the option to get values from collection by some key )
            Dictionary<string, string> firstDictionary = new Dictionary<string, string>();
            firstDictionary.Add("song1", "Have a nice day!");
            firstDictionary.Add("song2", "Wind of change");

            bool firstKeyExists = firstDictionary.ContainsKey("song2");
            bool thirdKeyExists = firstDictionary.ContainsKey("song3");
            Console.WriteLine(firstKeyExists);
            Console.WriteLine(thirdKeyExists);

            Console.WriteLine("Num of elements: " + firstDictionary.Count);
            Console.WriteLine(firstDictionary["song1"]); //get by key song1
            Console.WriteLine(firstDictionary["song2"]); //get by key song2

            Dictionary<int, string> products = new Dictionary<int, string>()
            {
                {23345, "Bread" },
                {33556, "Milk" },
                {36747, "Salt" }
            };
            iterateCollection(products); //Go trough the whole collection with our function created above
            Console.WriteLine(products[23345]);
            // Console.WriteLine(products[66666]); KeyNotFoundException
            bool success = products.TryGetValue(66666, out string product);
            bool success2 = products.TryGetValue(36747, out string secondProduct);

            //LIST - type and has no fixed length
            List<int> integerList = new List<int>();
            integerList.Add(3);
            integerList.Add(5);
            integerList.Add(6);
            integerList.Remove(5);
            //Console.WriteLine(integerList[2]); 
            Console.WriteLine(integerList[1]); //6
            Console.WriteLine(integerList.Count);
            integerList.RemoveAt(0);
            iterateCollection(integerList);

            //ArrayList - non generic
            //mixed ( Accepts all types and does not have constraint on number of elements )
            ArrayList arrayList = new ArrayList() { "Hello", 2};
            arrayList.Add(true);
            arrayList.Add(new string[] { "Hi", "Bye" });
            Console.WriteLine(arrayList[2]);
            Console.WriteLine(arrayList.Count);
            arrayList.Remove(2);
            Console.WriteLine(arrayList.Count);
            Console.WriteLine(((string[])arrayList[2])[0]);
            iterateCollection(arrayList);

            //QUEUE - First in First Out
            Queue<int> intQueue = new Queue<int>();
            intQueue.Enqueue(5); // Add item to the Queue
            intQueue.Enqueue(2); // Add item to the Queue
            intQueue.Enqueue(7); // Add item to the Queue
            iterateCollection(intQueue);
            int firstMember = intQueue.Peek(); //get the value of the first element
            Console.WriteLine(firstMember);
            Console.WriteLine(intQueue.Count);
            int firstMemberOut = intQueue.Dequeue(); //get the first element out of the queue
            Console.WriteLine(firstMemberOut);

            firstMember = intQueue.Peek();
            Console.WriteLine(firstMember);
            Console.WriteLine(intQueue.Count);

            //STACK - Last in First Out
            Stack<string> ourStack = new Stack<string>();
            ourStack.Push("Hello");
            ourStack.Push("Hi");
            ourStack.Push("Goodbye");
            iterateCollection(ourStack);
            string lastMember = ourStack.Peek();
            Console.WriteLine(lastMember);
            Console.WriteLine(ourStack.Count);

            string lastMemberOut = ourStack.Pop();//get the last element out of the queue

            lastMember = ourStack.Peek(); //get the value of the last element
            Console.WriteLine(lastMember);
            Console.WriteLine(ourStack.Count);


            Console.ReadLine();
        }
    }
}
