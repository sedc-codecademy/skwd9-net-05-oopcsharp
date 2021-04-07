using Exercises.Models;
using System;

namespace Exercises
{
    class Program
    {
        // method that will try to find User in an array (return null if not found)
        static User FindUser(User[] users, string username, string password)
        {
            foreach (User user in users)
            {
                if (user.Username.ToLower() == username.ToLower() && user.Password == password) return user;
            }
            return null;
        }
        // login method
        static void Login(User[] users, string username, string password)
        {
            User user = FindUser(users, username, password);
            if (user == null)
            {
                Console.WriteLine("User not found!");
                return;
            }
            Console.WriteLine("-------------------------");
            Console.WriteLine($"Welcome {user.Username}!");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Your messages:");
            user.PrintMessages();
            Console.WriteLine("-------------------------");
        }
        static void Register(User[] users, string username, string password, int id)
        {
            User user = FindUser(users, username, password);
            if (user != null)
            {
                Console.WriteLine("User already exists!");
                return;
            }
            Array.Resize(ref users, users.Length + 1);
            users[users.Length - 1] = new User(id, username,password, new string[] {} );
            Console.WriteLine("Successfully registered!");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Users registered so far:");
            Console.WriteLine("-------------------------");
            foreach (User u in users)
            {
                Console.WriteLine($"Id: {u.Id}, Username: {u.Username}");
            }
            Console.WriteLine("-------------------------");
        }
        static bool UsersUI(User[] users)
        {
            //Console.Clear();
            Console.WriteLine("Choose: \n1) Log in \n2)Register");
            int choice;
            bool isNumber = int.TryParse(Console.ReadLine(), out choice);
            if (!isNumber)
            {
                Console.WriteLine("That was not a number! Try again.");
                Console.WriteLine("-------------------------");
                return true;
            }
            switch (choice)
            {
                case 1:
                    Console.Write("Enter Username: ");
                    string username = Console.ReadLine();
                    Console.Write("Enter Password: ");
                    string password = Console.ReadLine();
                    Login(users, username, password);
                    return true;
                case 2:
                    Console.Write("Enter Id: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Enter Username: ");
                    string newUsername = Console.ReadLine();
                    Console.Write("Enter Password: ");
                    string newPassword = Console.ReadLine();
                    Register(users, newUsername, newPassword, id);
                    return true;
                default:
                    Console.WriteLine("Please enter 1 or 2");
                    Console.WriteLine("-------------------------");
                    return true;
            }
        }
        static void Main(string[] args)
        {
            /*
            Creata a program that will represent User Login and Register functionality
            - The User should have two options : 
                1) Log in 
                2) Register
            - Class User: Id, Username, Password, Messages
            - If a user is successfully logged in, it should show his messages
                e.g. Your messages: "his message here"
            - Note: Provide basic Login and Register validation
            */

            // TO DO:
            // 1. Class
            // 2. Login & register methods
            // 3. Instantiate objects in an array
            // 4. UI

            User[] users = new User[]
               {
                    new User(24,"Bob23", "mysuperpass",new string[]{"Hey bob! Nice shirt.", "Call me pls!"  }),
                    new User(12, "Jill_awesome", "123456", new string[]{"How are ya? Call me", "When will you go to work?", "Your card is ready!" }),
                    new User(5, "GregGregsky", "lozinka", new string[]{"Come to my party tomorrow!", "Drunk message. Please don't take it seriously." })
               };
            while (UsersUI(users));
            Console.ReadLine();
        }
    }
}
