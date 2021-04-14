using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    //Logic
            //}
            //catch (Exception ex)
            //{
            //    //Things that will be done if exception is thrown
            //}
            //finally
            //{
            //    //piece of code that will be executed no matter what
            //}

            try
            {
                List<string> list = new List<string>();
                string firstElement = list.First();

                Console.WriteLine("The element is: ");
                Console.Write(firstElement);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Error happened please contact administrator: {ex.Message}");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Error happened please contact administrator");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error happened please contact administrator");
            }
        }
    }
}
