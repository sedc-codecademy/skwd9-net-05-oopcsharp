using System;
using Task03.Classes;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            User[] users = new User[3];
            users[0] = new User()
            {
                Id = 1,
                Username = "Bob23",
                Password = "mysuperpass",
                Messages = new string[] { "Hey bob! Nice shirt.", "Call me pls!"
                }
            };
            users[1] = new User()
            {
                Id = 2,
                Username = "Paul26",
                Password = "Paul26Paul",
                Messages = new string[] { "Hey Paul!", "How are you?"
                }
            };
            users[2] = new User()
            {
                Id = 3,
                Username = "Ana13",
                Password = "AnaBanana",
                Messages = new string[] { "Hey Ana! Nice hat.", "See you later."
                }
            };
            while (true)
            {
                Console.WriteLine("Choose: \n1) Log in \n2)Register");
                int choice;
                bool isNumber = int.TryParse(Console.ReadLine(), out choice);
                if (!isNumber)
                {
                    Console.WriteLine("That was not a number! Try again.");
                    continue;
                }
                if (choice == 1)
                {
                    Console.Write("Enter Username: ");
                    string username = Console.ReadLine();
                    if (string.IsNullOrEmpty(username))
                    {
                        Console.WriteLine("You must enter a username");
                        continue;
                    }
                    Console.Write("Enter Password: ");
                    string password = Console.ReadLine();
                    if (string.IsNullOrEmpty(password))
                    {
                        Console.WriteLine("You must enter a password");
                        continue;
                    }
                    Login(users, username, password);
                    break;
                }
                else if (choice == 2)
                {
                    Console.Write("Enter Id: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Enter Username: ");
                    string newUsername = Console.ReadLine();
                    if (string.IsNullOrEmpty(newUsername))
                    {
                        Console.WriteLine("You must enter a username");
                        continue;
                    }
                    Console.Write("Enter Password: ");
                    string newPassword = Console.ReadLine();
                    if (string.IsNullOrEmpty(newPassword))
                    {
                        Console.WriteLine("You must enter a password");
                        continue;
                    }
                    Register(users, newUsername, newPassword, id);
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter 1 or 2");
                    continue;
                }

            }
            Console.ReadLine();
        }
        //This function is needed in order to find a given user
        //whether by usename and password or only by username
        static User FindUser(User[] users, string username, string password = null)
        {
            if (!string.IsNullOrEmpty(password))
            {
                foreach (User user in users)
                {
                    if (user.Username.ToLower() == username.ToLower() && user.Password == password)
                        return user;
                }
            }
            else
            {
                foreach (User user in users)
                {
                    if (user.Username.ToLower() == username.ToLower())
                        return user;
                }
            }
            return null;
        }
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
            foreach (string message in user.Messages)
            {
                Console.WriteLine(message);
            }
            Console.WriteLine("-------------------------");
        }
        static void Register(User[] users, string username, string password, int id)
        {
            User user = FindUser(users, username);
            if (user != null)
            {
                Console.WriteLine("User already exists!");
                return;
            }
            Array.Resize(ref users, users.Length + 1);
            users[users.Length - 1] = new User() { Id = id, Username = username, Password = password };
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

    }
}

