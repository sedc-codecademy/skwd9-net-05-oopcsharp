using System;
using System.Collections;
using System.Collections.Generic;

namespace SEDC.CSharpOop.Class08.Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array
            int[] integerArray = new int[4];
            string[] strArray = new string[] { "Hello", "World", "!" };
            //Array.Resize(ref strArray, 10);
            //strArray[strArray.Length - 1] = ":::";
            // GoThroughCollection(strArray, "Array"); 
            //Console.WriteLine("Length: " + strArray.Length);// Get number of elements in the collection

            // ArrayList ( Accepts all types and does not have constraint on number of elements )
            ArrayList arrayList = new ArrayList() { "Hello", 2, true, 2.33 };
            arrayList.Add(9);
            arrayList.Add(strArray);
            arrayList.Remove(true);
            //Console.WriteLine(arrayList[3]);
            //GoThroughCollection(arrayList, "ArrayList"); // Go trough the whole collection with our function created above
            //Console.WriteLine("Length: " + arrayList.Count); // Get number of elements in the collection

            // List ( Has designated type and does not have constraint on number of elements )
            List<int> listOfInts = new List<int>();
            listOfInts.Add(3);
            listOfInts.Add(5);
            listOfInts.Add(7);
            listOfInts.Add(9);
            listOfInts.Add(11);
            listOfInts.Add(13);
            listOfInts.Add(15);
            // GoThroughCollection(listOfInts, "List"); // Go trough the whole collection with our function created above

            List<string> srtList = new List<string>() { "Hello", "World", "!" };
            srtList.Add("Trajan");
            srtList.Add("Stevkovski");
            // srtList.AddRange(strArray);
            srtList.Remove("Trajan");
            srtList.Remove(strArray[1]);
            //Console.WriteLine(srtList[0]);
            //GoThroughCollection(srtList, "List");
            //Console.WriteLine("Length: " + srtList.Count); // Get number of elements in the collection

            // type     key     value
            Dictionary<string, string> dictionaryOne = new Dictionary<string, string>();
            dictionaryOne.Add("song1", "Winds of Change");
            dictionaryOne.Add("song2", "Enter Sandman");
            // dictionaryOne.Add("song1", "asd"); // key are unique and we canot add 2 keys with same value
            string song = dictionaryOne["song2"];
            // Console.WriteLine(dictionaryOne[2]); // ditionary dont have indexes
            //Console.WriteLine(song);
            // GoThroughCollection(dictionaryOne, "Dictionary");
            Dictionary<int, string> dictionaryTwo = new Dictionary<int, string>()
            {
                { 1, "Hello" },
                { 2, "World" },
                { 3, "!" },
                { 4, "!" }
            };
            string item1 = dictionaryTwo[2];
            //Console.WriteLine(item1);
            dictionaryTwo.Remove(2);
            // GoThroughCollection(dictionaryTwo, "Dictionary");
            //int keyNumber = 3;
            //Console.WriteLine(dictionaryTwo[keyNumber]);
            //foreach(KeyValuePair<int, string> item in dictionaryTwo)
            //{
            //    Console.WriteLine(item.Key);
            //    Console.WriteLine(item.Value);
            //}
            //Console.WriteLine("Length: " + dictionaryTwo.Count);


            Queue<int> someQueue = new Queue<int>();
            someQueue.Enqueue(25); // adds item in queue
            someQueue.Enqueue(2);
            someQueue.Enqueue(3);
            someQueue.Enqueue(112);
            //GoThroughCollection(someQueue, "Queue");
            int someNum = someQueue.Dequeue();
            //GoThroughCollection(someQueue, "Queue");
            // someQueue[2]; // cannot use indexes
            //Console.WriteLine(someQueue.Peek());
            //Console.WriteLine("Length: " + someQueue.Count);

            Stack<string> someStack = new Stack<string>();
            someStack.Push("Hey"); // add item to the stack
            someStack.Push("Hello");
            someStack.Push("Hi");
            someStack.Push("Zdravo");
            //GoThroughCollection(someStack, "Stack");
            //string someString = someStack.Pop();
            //Console.WriteLine(someString);
            //GoThroughCollection(someStack, "Stack");
            //Console.WriteLine(someStack.Peek());
            //Console.WriteLine("Length: " + someStack.Count);

            Console.ReadLine();
        }

        static void GoThroughCollection(IEnumerable collection, string name)
        {
            Console.WriteLine($"Collection {name} items: ");
            foreach (var item in collection)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();
        }
    }
}
