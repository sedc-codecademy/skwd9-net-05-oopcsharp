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
            Console.WriteLine("Length: " + strArray.Length);// Get number of elements in the collection

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
            GoThroughCollection(listOfInts, "List"); // Go trough the whole collection with our function created above

            List<string> srtList = new List<string>() { "Hello", "World", "!" };
            srtList.Add("Trajan");
            srtList.Add("Stevkovski");
            // srtList.AddRange(strArray);
            srtList.Remove("Trajan");
            srtList.Remove(strArray[1]);
            Console.WriteLine(srtList[0]);
            GoThroughCollection(srtList, "List");
            Console.WriteLine("Length: " + srtList.Count); // Get number of elements in the collection


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
