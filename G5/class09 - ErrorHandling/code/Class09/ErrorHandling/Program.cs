using System;

namespace ErrorHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //Compile-Time error
            //string name = 256;
            //var result = 10 / 0;

            //Run-Time error
            var number1 = 10;
            var number2 = 0;

            try
            {
                var result = number1 / number2;
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Something bad has happened! Error is {ex.Message}");
            }
            finally
            {
                Console.WriteLine("This will execute in any scenario, and is optional.");
            }


            
            Console.ReadLine();
        }
    }
}
