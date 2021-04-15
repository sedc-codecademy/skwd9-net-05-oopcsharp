using SEDC.OopCSharp.Exceptions.Demo;
using System;
using System.Collections.Generic;

namespace SEDC.OopCSharp.Exceptions.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Compiletime error
            //int age = "Damjan";


            //Runtime exception
            DemoClass demoObj = new DemoClass();
            List<int> numbers = new List<int> { 32, 11, 74, 57, 93 };
            //try
            //{
            //    int elementAtPositionFour = demoObj.GetNumberAtCertainPositionParent(5, numbers);
            //    Console.WriteLine($"The element at position 4 is {elementAtPositionFour}");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"This is the error message: {ex.Message}"); ;
            //    Console.WriteLine($"This is the error stacktrace: {ex.StackTrace}");
            //}

            try
            {
                int number = int.Parse("548909280964580948905698469054940");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"The message from this excpetion is {ex.Message}");
            }
            catch(ArgumentNullException argEx)
            {
                Console.WriteLine($"The given parametar can not be null {argEx.Message}");
            }
            catch(Exception ex)
            {
                Console.WriteLine("There was an error!");
            }
            //This block throws a compile time error because the last catch is of type Exception.
            //Can not have catch clause after Exception catch.
            //We go from more specific exceptions to more genereic
            //catch(OverflowException overflowEx)
            //{

            //}
            try
            {
                //bool isValidBoolean = bool.Parse("tocno");
                throw new MyException("This is the message from my custom exception class",400);
            }
            catch(FormatException formatExeption)
            {
                Console.WriteLine("The code above was of type format exception");
            }
            catch (MyException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            
            Console.ReadLine();
        }
    }
}
