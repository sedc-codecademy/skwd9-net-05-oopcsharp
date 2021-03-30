using System;

namespace SEDC.CSharpOop.Class03.Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // inicialization and declaration for empty integer array
            int[] emptyIntArray = new int[3];
            // adding element values to array
            emptyIntArray[0] = 12;
            emptyIntArray[1] = 3;
            emptyIntArray[2] = -12;
            // what array looks like in console
            Console.WriteLine(emptyIntArray);
            // print element on the second position in array
            Console.WriteLine(emptyIntArray[2]);

            // trying to set 4th element 
            // emptyIntArray[3] = 32;

            // inicialization and declaration for array
            string[] names = new string[] { "Bob", "Jill", "Kenny", "March" };
            bool[] trueFalseArray = new bool[] { true, false, false, false, false, true };
            char[] characterArray = new char[] { 'a', 'b', 'v', 'd', 'e', 'f' };

            // short way of creating arr
            int[] nums = { 1, 2, 3, 5 , 4, 6, 7 };
            // get array length
            Console.WriteLine("Nums arr has " + nums.Length + " Elements");

            int indexOf = Array.IndexOf(nums, 5);
            Console.WriteLine("Index of 5 is " + indexOf);
            Console.WriteLine(nums[indexOf]);

            Console.WriteLine("First number is: " + nums[0]);

            Array.Reverse(nums);

            Console.WriteLine("First number in reversed array is: " + nums[0]);

            Array.Resize(ref nums, 10);
            nums[8] = 123;
            Console.WriteLine("New length of nums array is :" + nums.Length);

            Console.ReadLine();
        }
    }
}
