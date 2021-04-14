using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.CSharpOop.Class08.BasicLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 4, 5, 3, 12, 32, 1, 3, 2, 17, 23 };

            List<int> numbersBiggerThenTen = new List<int>();
            foreach(int number in numbers)
            {
                if(number > 10)
                {
                    numbersBiggerThenTen.Add(number);
                }
            }
            //GoThroughCollection(numbersBiggerThenTen, "numbersBiggerThenTen");

            List<int> numbersBiggerThenTenLINQ = numbers.Where(x => x > 10).ToList();
            //GoThroughCollection(numbersBiggerThenTenLINQ, "numbersBiggerThenTenLINQ");

            List<int> numbersMappedWithPlusSeven = new List<int>();
            foreach(int number in numbers)
            {
                int math = number + 7;
                numbersMappedWithPlusSeven.Add(math);
            }
            //GoThroughCollection(numbersMappedWithPlusSeven, "numbersMappedWithPlusSeven");

            List<int> numbersMappedWithPlusSevenLINQ = numbers.Select(x => x + 7).ToList();
            //GoThroughCollection(numbersMappedWithPlusSevenLINQ, "numbersMappedWithPlusSevenLINQ");

            List<int> numbersMappedWithPlusSeven1 = new List<int>();
            foreach (int number in numbers)
            {
                int math = number + 7;
                numbersMappedWithPlusSeven1.Add(math);
            }

            List<int> numbersBiggerThenTen1 = new List<int>();
            foreach (int number in numbersMappedWithPlusSeven1)
            {
                if (number > 10)
                {
                    numbersBiggerThenTen1.Add(number);
                }
            }
            //GoThroughCollection(numbersBiggerThenTen1, "numbersBiggerThenTen1");

            List<int> numbersMappedWithPlusSevennumbersBiggerThenTenLINQ =
                numbers.Select(x => x + 7).Where(x => x > 10).ToList();
            //GoThroughCollection(numbersMappedWithPlusSevennumbersBiggerThenTenLINQ,
            //    "numbersMappedWithPlusSevennumbersBiggerThenTenLINQ");

            List<int> numbersBiggerThenTennumbersMappedWithMinusSevenLINQ =
                numbers.Where(x => x > 10).Select(x => x - 7).ToList();
            //GoThroughCollection(numbersBiggerThenTennumbersMappedWithMinusSevenLINQ,
            //   "numbersBiggerThenTennumbersMappedWithMinusSevenLINQ");


            //ComplexObjectWithLinq();

            int num1 = numbers.First(x => x == 3); 
            Console.WriteLine(num1);
            //int num2 = numbers.First(x => x == 123); // this will throw an error

            int num3 = numbers.FirstOrDefault(x => x == 3);
            Console.WriteLine(num3);
            int num4 = numbers.FirstOrDefault(x => x == 123);
            Console.WriteLine(num4);

            int num5 = numbers.Last(x => x == 17);
            Console.WriteLine(num5);
            //int num6 = numbers.Last(x => x == 123);

            int num7 = numbers.LastOrDefault(x => x == 3);
            Console.WriteLine(num7);
            int num8 = numbers.LastOrDefault(x => x == 123);
            Console.WriteLine(num8);

            Console.ReadLine();
        }


        static void ComplexObjectWithLinq()
        {
            List<LinqDemo> linqDemos = new List<LinqDemo>()
            {
                new LinqDemo() { Id = 1, Name = "One" },
                new LinqDemo() { Id = 2, Name = "Two" },
                new LinqDemo() { Id = 3, Name = "Three" },
                new LinqDemo() { Id = 4, Name = "Four" },
                new LinqDemo() { Id = 5, Name = "Five" },
                new LinqDemo() { Id = 6, Name = "Six" },
                new LinqDemo() { Id = 7, Name = "Seven" },
                new LinqDemo() { Id = 8, Name = "Eight" },
                new LinqDemo() { Id = 9, Name = "Nine" },
                new LinqDemo() { Id = 10, Name = "Ten" },
                new LinqDemo() { Id = 11, Name = "Eleven" },
                new LinqDemo() { Id = 12, Name = "Twelve" },
                new LinqDemo() { Id = 13, Name = "Trinaeset :)" },
            };

            List<string> idBiggerThenTenAndSelectNames = 
                linqDemos.Where(x => x.Id > 10).Select(x => x.Name).ToList();
            GoThroughCollection(idBiggerThenTenAndSelectNames, "idBiggerThenTenAndSelectNames");
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
