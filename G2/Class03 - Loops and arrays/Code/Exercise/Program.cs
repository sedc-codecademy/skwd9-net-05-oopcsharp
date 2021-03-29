using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter number of trees: ");
            bool success = int.TryParse(Console.ReadLine(), out int trees);
            if (success)
            {
                int n = 8;
                int m = 5;
                int treeApples = n * 12 * trees;
                int result;
                if (treeApples % m == 0)
                {
                    result = treeApples / m;
                }
                else
                {
                    result = treeApples / m + 1;
                }
                Console.WriteLine("You would need :" + result + " baskets!");
            }
            Console.ReadLine();
        }
    }
}
