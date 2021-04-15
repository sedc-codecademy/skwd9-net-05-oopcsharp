using Exceptions.Entities;
using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    Console.WriteLine("Please insert a number");
            //    int userNumber = int.Parse(Console.ReadLine());
            //    Console.WriteLine(userNumber);
            //}
            //catch (Exception ex)
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("You should have inserted a number!");
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine(ex.StackTrace);
            //}
            //finally
            //{
            //    Console.ForegroundColor = ConsoleColor.White;
            //    Console.WriteLine("Please enter any key to exit..");
            //}

            //Console.WriteLine("Please enter hi or bye");
            //try
            //{
            //    string userInput = Console.ReadLine();
            //    if (userInput != "hi" && userInput != "bye")
            //    {
            //        throw new Exception("You should have inserted hi or bye!");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine(ex.Message);
            //} 
            //finally
            //{
            //    Console.ForegroundColor = ConsoleColor.White;
            //    Console.WriteLine("End of application");
            //    Console.ReadLine();
            //}


            // Specific exceptions
            try
            {
                Console.WriteLine("Please enter a character");
                char userCharacter = char.Parse(Console.ReadLine()); // FORMAT EXCEPTION 

                int[] integers = new int[] { 1, 2, 3 };
                // Console.WriteLine(integers[3]); // INDEX OUT OF RANGE EXCEPTION

                //int value = int.Parse(Console.ReadLine());
                //int result = value * value;

                //Student student = null; // null reference exception
                //student.FirstName = "John";

            }
            catch (FormatException ex)
            {
                Console.WriteLine("You inserted invalid input!");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("The array does not have element with that index!");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("YOu broke the memory!");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("You tried to access something from null");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error ocured");
            }

            try
            {
                Student student = new Student()
                {
                    FirstName = "Bob",
                    LastName = "Bobsky"
                };

                printStudentSubjectsWithoutTry(student);
                printStudentSubjectsWithTry(student);
            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Subjects must not be null");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }
        static void printStudentSubjectsWithoutTry(Student student)
        {
            foreach (Subject subject in student.Subjects)
            {
                Console.WriteLine(subject.Name);
            }
        }

        static void printStudentSubjectsWithTry(Student student)
        {
            try
            {
                foreach (Subject subject in student.Subjects)
                {
                    Console.WriteLine(subject.Name);
                }
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine("FROM INSIDE THE FUNCTION");
                Console.WriteLine(ex.Message);
                Console.WriteLine("-------------------------------");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }

}
