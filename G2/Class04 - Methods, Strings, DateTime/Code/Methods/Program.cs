using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Greet();
            GreetSomeone("");
            GreetSomeone("Paul");

            string greeting = GetGreeting("SEDC");
            Console.WriteLine($"Greeting: {greeting}");
            Console.WriteLine(GetGreeting("Bob"));

            Program program = new Program();
            program.nonStaticMethod();

            Console.ReadLine();
        }

        //no return
        static void Greet()
        {
            Console.WriteLine("Hello from our first method!");
            Console.ReadLine();
        }

        //parameters
        static void GreetSomeone(string name)
        {
            if (String.IsNullOrEmpty(name))
            {
                Console.WriteLine("We can not greet the person!");
            }
            else
            {
                Console.WriteLine($"Hello {name}");
            }
            Console.ReadLine();
        }
        //with return type
        static string GetGreeting(string name)
        {
            if (String.IsNullOrEmpty(name))
            {
                return "We can not greet the person!";
            }
                return $"Hello {name}";

        }

        //return type is int, the data that is returned is of type int
        static int GetNumber()
        {
            return 5 + 2;
        }

        //non static methods are called via an object
        void nonStaticMethod()
        {
            Console.WriteLine("Hello from our non static method!");
        }
        
    }
}
