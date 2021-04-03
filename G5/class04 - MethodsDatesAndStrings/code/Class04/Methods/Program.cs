using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = SayHello("Viktor", 31);
            Console.WriteLine(result);
            string result2 = SayHello("Angela", 25);
            Console.WriteLine(result2);
            SayBye();
            CheckDroids2(false);
            CheckDroids3(true);
        }

        // method with input prameters that returns integer
        public static string SayHello(string name, int age) 
        {
            string result = "Hello, I am " + name + " and I am " + age + " years old!";
            return result;
        }

        // method that does not have any input parameters and returns nothing
        public static void SayBye() 
        {
            Console.WriteLine("Bye");
        }

        // method with parameters but no reutrn ( void )
        static void CheckDroids2(bool isJedi)
        {
            if (isJedi)
            {
                Console.WriteLine("These aren't the droids you are looking for.");
            }
            else
            {
                Console.WriteLine("Take the droids. It's cool.");
            }
        }

        static string JediMindTrick()
        {
            return "These aren't the droids you are looking for.";
        }

        // Function with parameters and return
        static string CheckDroids3(bool isJedi)
        {
            if (isJedi)
            {
                return JediMindTrick(); // We can call functions inside of functions
            }
            else
            {
                return "Take the droids. It's cool.";
            }
        }



    }
}
