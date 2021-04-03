using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // DONT DO THIS, THIS IS FOR DEMO PURPOSES
            //(new Program()).HelloWorld();
            //StaticHelloWorld();
            //Console.WriteLine("Are you bored already");
            //StaticHelloWorld();

            //PrintFullName("John", "Doe");
            //string fName = "Bob";
            //string lName = "Bobsky";
            //PrintFullName(fName, lName);
            Console.Write("Please insert first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Please insert last name: ");
            string lastName = Console.ReadLine();
            // PrintFullName(firstName, lastName);

            //string fullName = GetFullName(fName, lName);
            string fullName = GetFullName(firstName, lastName);
            Console.WriteLine(fullName);
            // PrintFullName("Stojce");

        }

        static bool ValidateFirstName(string firstName)
        {
            if(firstName.Length > 1)
            {
                return true;
            } else
            {

                Console.WriteLine("First name is invalid!");
                return false;
            }
        }

        static bool ValidateLastName(string lastName)
        {
            if (lastName.Length > 1)
            {
                return true;
            }
            else
            {

                Console.WriteLine("Last name is invalid!");
                return false;
            }
        }

        static string GetFullName(string firstName, string lastName)
        {
            // we can call other methods in our methods
            bool validateFirstName = ValidateFirstName(firstName);
            bool validateLastName = ValidateLastName(lastName);
            if (validateFirstName && validateLastName)
            {
                return firstName + " " + lastName;
            }
            return "";
        }

        static void PrintFullName(string firstName, string lastName = "Stojcevski")
        {
            Console.WriteLine(firstName + " " + lastName);
        }


        void HelloWorld()
        {
            Console.WriteLine("HELLO WORLD");
        }

        static void StaticHelloWorld()
        {
            Console.WriteLine("HELLO WORLD FROM STATIC");
        }
    }
}
