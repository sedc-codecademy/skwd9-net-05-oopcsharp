using System;
using System.Collections;
using System.Collections.Generic;

namespace EnumerableExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>()
            {
                {1, "Risto"},
                {3, "Adis"},
                {5, "Martin"}
            };
            PrintCollection(students);

            List<string> footballClubs = new List<string>() {"Real Madrid", "Liverpool", "Bayern", "PSG"};
            PrintCollection(footballClubs);

            Queue<int> evenNumbers = new Queue<int>();
            evenNumbers.Enqueue(2);
            evenNumbers.Enqueue(4);
            evenNumbers.Enqueue(6);
            evenNumbers.Enqueue(8);
            PrintCollection(evenNumbers);

            Stack<bool> stack = new Stack<bool>();
            stack.Push(true);
            stack.Push(true);
            stack.Push(false);
            stack.Push(false);
            PrintCollection(stack);
        }

        static void PrintCollection(IEnumerable collection)
        {
            foreach (object item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
