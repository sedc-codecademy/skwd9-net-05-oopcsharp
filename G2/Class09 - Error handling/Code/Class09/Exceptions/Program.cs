using Entities;
using System;

namespace Exceptions
{
    class Program
    {
        static void printSkillsWithoutTry(Human human)
        {
            //human.Skills could potentially be null
            foreach (Skill skill in human.Skills)
            {
                Console.WriteLine(skill.Name);
            }
        }

        static void printSkillsWithTry(Human human)
        {
            //human.Skills could potentially be null
            try
            {
                foreach (Skill skill in human.Skills)
                {
                    Console.WriteLine(skill.Name);
                }
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("Inside the function");
                Console.WriteLine(e.Message);
                Console.WriteLine("Skills must not be null");
            }
            catch (Exception e)
            {
                Console.WriteLine("Inside the function");
                Console.WriteLine(e.Message);
            }
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Enter a number");

            try
            {
                int number = Int32.Parse(Console.ReadLine());
                Console.WriteLine($"You entered: {number}");
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("An error occured. Try again");
                Console.WriteLine(ex);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("End of entering number");
                Console.ReadLine();
            }

            Console.WriteLine("Enter a or b");
            try
            {
                string letter = Console.ReadLine();
                if (letter != "a" && letter != "b")
                {
                    throw new Exception("You must enter a or b");
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("End of entering a or b");
                Console.ReadLine();
            }


            //SPECIFIC EXCEPTIONS
            try
            {
                Console.WriteLine("Enter a character");
                char character = char.Parse(Console.ReadLine()); //format exception
                Console.WriteLine("Enter a number");
                int num = int.Parse(Console.ReadLine()); //format exception

                //Index out of range
                int[] ints = new int[] { 1, 4, 5 };
                //Console.WriteLine(ints[3]);

                Human human = null;
                //human.FirstName = "Ana"; //null reference

                int value = 780000000;
                int square = value * value; //overflow

                throw new Exception("My exception");
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Input could not be parsed!");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Index was invalid!");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Object was null!");
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("You broke the memory!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Human human = new Human() { FirstName = "Petar", LastName = "Stojanovski" };
                //exception is propagated to the outside
                //printSkillsWithoutTry(human); - exception

                //exception is handled in the function
                printSkillsWithTry(human);
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Skills must not be null");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
