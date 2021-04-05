using System;

namespace ClassExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 01
            Human human01 = new Human();

            //Console.WriteLine("Enter first name:");
            //string firstNameInput = Console.ReadLine();

            //Console.WriteLine("Enter last name:");
            //string lastNameInput = Console.ReadLine();

            //Console.WriteLine("Enter age:");
            //int ageInput = int.Parse(Console.ReadLine());

            //human01.FirstName = firstNameInput;
            //human01.LastName = lastNameInput;
            //human01.Age = ageInput;

            //human01.GetPersonStats();

            Dog dog01 = new Dog();

            Console.WriteLine("Enter name:");
            dog01.Name = Console.ReadLine();

            Console.WriteLine("Enter breed:");
            dog01.Breed = Console.ReadLine();

            Console.WriteLine("Enter color:");
            dog01.Color = Console.ReadLine();

            Console.WriteLine("Enter one of the following activities:");
            Console.WriteLine("1. Eat 2.Play 3.ChaseTail");
            int userChoice = int.Parse(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    Console.WriteLine(dog01.Eat());
                    break;
                case 2:
                    Console.WriteLine(dog01.Play());
                    break;
                case 3:
                    Console.WriteLine(dog01.ChaseTail());
                    break;
                default:
                    Console.WriteLine("Invalid number");
                    break;
            }



            Console.ReadLine();
        }
    }
}
