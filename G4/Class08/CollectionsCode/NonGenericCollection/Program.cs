using System;
using System.Collections;

namespace NonGenericCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Non-Generic Collections!");

            // Arrays review
            int[] numbers = new int[3];
            int[] otherNumbers = new int[] { 1, 2, 3 };
            int[] anotherNumbers = { 4, 5, 6 };

            // ArrayList
            ArrayList firstArrayList = new ArrayList();

            // Adding elements in the ArrayList
            firstArrayList.Add(12);
            firstArrayList.Add("Some random string");
            firstArrayList.Add(true);
            // adds the array as a separate member
            firstArrayList.Add(anotherNumbers);

            foreach (var item in firstArrayList)
            {
                Console.WriteLine(item);
            }
            int firstElement = (int)firstArrayList[0];
            // add Range destructures the array and it adds them as separate members
            firstArrayList.AddRange(new int[2] { 30, 40 });
            Console.WriteLine("----------------------------");
            foreach (var item in firstArrayList)
            {
                Console.WriteLine(item);
            }

            // removing items
            firstArrayList.Remove(anotherNumbers);

            Console.WriteLine(firstArrayList.Count);

            // We can't use the .Sort() method
            //firstArrayList.Sort();

            Console.ReadLine();
        }
    }
}
