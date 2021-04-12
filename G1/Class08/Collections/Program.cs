using System;
using System.Collections.Generic;
using Models;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Dictionary
            // 1, Martin
            // 2, Ivan
            // 3, Goran
            Dictionary<int, string> students = new Dictionary<int, string>
            {
                {1, "Martin" },
                {2, "Ivan" },
                {3, "Goran" },
                {6, "Aleksandar" }
            };

            int numberOfElementsInDictionary = students.Count;

            //Console.WriteLine("Please enter student card:");
            //string cardString = Console.ReadLine();
            //Console.WriteLine("Please enter student name:");
            //string name = Console.ReadLine();

            //if (!int.TryParse(cardString, out int card))
            //{
            //    Console.WriteLine("Wrong input.");
            //    return;
            //}

            ////students.Add(card, name);
            ////bool successfulAdd = students.TryAdd(card, name);

            //bool keyExists = students.ContainsKey(card);

            //if (!keyExists)
            //{
            //    students.Add(card, name);
            //}

            string student = students[6];
            //students.Remove(6);

            //students.Remove(6, out string student);

            foreach (KeyValuePair<int, string> s in students)
            {
                Console.WriteLine($"{s.Key}: {s.Value}");
            }

            Dictionary<string, Person> citizens = new Dictionary<string, Person>();

            citizens.Add("A000111", new Person("Risto", "Panchevski", new DateTime(1989, 7, 20), "Gjorce"));
            citizens.Add("A999111", new Person("Adis", "Drndar", new DateTime(1999, 01, 01), "Gjorce"));

            foreach (KeyValuePair<string, Person> citizen in citizens)
            {
                Console.WriteLine($"LK. {citizen.Key}, {citizen.Value.FullName}");
            }
            #endregion

            #region List
            List<string> trainers = new List<string>()
            {
                "Risto",
                "Adis",
                "Viktor",
                "Risto",
                "Vesna"
            };

            string firstTrainer = trainers[0];
            //trainers[0] = "Darko";
            trainers.Add("Martin");
            //trainers.Remove("Risto");
            //trainers.RemoveAt(0);

            //while (true)
            //{
            //    if (trainers.Contains("Risto"))
            //    {
            //        trainers.Remove("Risto");
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}

            //while (trainers.Contains("Risto"))
            //{
            //    trainers.Remove("Risto");
            //}

            //trainers.RemoveAll(trainer => trainer.StartsWith("V"));
            int removedElements = trainers.RemoveAll(trainer => trainer == "Risto");

            List<int> numbers = new List<int>() { 2, 4, 6, 8 };
            List<int> oddNumbers = new List<int>() { 1, 3, 5, 7, 9 };

            numbers.AddRange(oddNumbers);
            int n = numbers.Count;
            bool exists = oddNumbers.Exists(number => number % 2 == 0);

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine(oddNumbers);
            #endregion

            #region Queue
            Queue<int> myQueue = new Queue<int>();
            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(3);
            //myQueue.Enqueue(4);
            //myQueue.Enqueue(5);

            int firstNumber = myQueue.Dequeue();
            int secondNumber = myQueue.Dequeue();

            //int thirdNumber = myQueue.Peek();
            bool elementExists = myQueue.TryPeek(out int thirdNumber);
            bool elementExists1 = myQueue.TryDequeue(out int lastNumber);
            #endregion

            #region Stack

            Stack<int> myStack = new Stack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            myStack.Push(5);

            int firstNumberStack = myStack.Pop();
            //int secondNumberStack = myStack.Pop();
            //int thirdNumberStack = myStack.Peek();

            bool secondNumberStackExists = myStack.TryPop(out int secondNumberStack);
            bool thirdNumberStackExists = myStack.TryPeek(out int thirdNumberStack);

            foreach (int stackElement in myStack)
            {
                Console.WriteLine(stackElement);
            }
            #endregion
        }
    }
}
