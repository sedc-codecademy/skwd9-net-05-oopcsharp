using SpecificExceptions.CustomExceptions;
using SpecificExceptions.enums;
using System;

namespace SpecificExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Some code...");

            try
            {
                SpecificExceptions(ExceptionSimulator.CustomException);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("This is the overflow exeption catch!");
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("This is the format exeption catch!");
                Console.WriteLine(ex.Message);
            }
            catch (SystemException ex)
            {

            }
            catch (ViktorException ex) 
            {
                Console.WriteLine("This is the custom exeption catch!");
                Console.WriteLine(ex.CustomErrorMessage);
                Console.WriteLine(ex.Service);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.Write("Some other code...");
        }

        public static void SpecificExceptions(ExceptionSimulator es) 
        {
            if (es == ExceptionSimulator.OverflowException)
            {
                checked 
                {
                    int result = int.MaxValue + int.Parse("1");
                    Console.WriteLine(result);
                }
            }

            if (es == ExceptionSimulator.FormatException)
            {
                int input = int.Parse(Console.ReadLine());
                Console.WriteLine(input);
            }

            if (es == ExceptionSimulator.CustomException)
            {
                throw new ViktorException("Viktor exception custom message", "Viktor service");
            }

            if (es == ExceptionSimulator.Exception) 
            {
                throw new Exception("This is the exception message!");
            }
        }
    }
}
