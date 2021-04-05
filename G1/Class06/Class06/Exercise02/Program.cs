using System;
using System.Globalization;
using System.Text;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            //int sum = 1000;
            //Console.WriteLine(sum.ToString("C", new CultureInfo("en-US")));

            User[] users = new User[3];
            users[0] = new User(1, "Risto", "test123");
            users[1] = new User(2, "Adis", "test321");
            users[2] = new User(3, "Darko", "test");
            
            while (true)
            {
                Console.WriteLine("Please select:\n1. Login\n2. Register");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Login(users);
                        break;
                    case "2":
                        Console.WriteLine("Id:");
                        string idString = Console.ReadLine();
                        Console.WriteLine("Username:");
                        string username = Console.ReadLine();
                        Console.WriteLine("Password:");
                        string password = Console.ReadLine();
                        Console.WriteLine("Confirm password:");
                        string confirmPassword = Console.ReadLine();

                        bool successParse = int.TryParse(idString, out int id);

                        if (!successParse)
                        {
                            Console.WriteLine("Wrong input for Id");
                            continue;
                        }

                        if (UsernameExists(username, users))
                        {
                            Console.WriteLine("Username already exists");
                            continue;
                        }

                        if (password != confirmPassword)
                        {
                            Console.WriteLine("Password and Confirmed password does not match");
                            continue;
                        }

                        User newUser = new User(id, username, password);
                        Array.Resize(ref users, users.Length + 1);
                        users[users.Length - 1] = newUser;
                        //users[^1] = newUser;
                        Console.WriteLine("Registration complete!");
                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }
            }
        }

        static void Login(User[] users)
        {
            Console.WriteLine("Username:");
            string username = Console.ReadLine();
            Console.WriteLine("Password:");
            string password = Console.ReadLine();
            bool foundUser = false;

            foreach (User user in users)
            {
                if (user.Username == username && user.Password == password)
                {
                    Console.WriteLine($"Welcome {user.Username}. Here are your messages:");
                    foreach (string message in user.Messages)
                    {
                        Console.WriteLine(message);
                    }

                    foundUser = true;
                    //return;
                }
            }

            if (!foundUser)
            {
                Console.WriteLine("User not found");
            }
        }

        static bool UsernameExists(string username, User[] users)
        {
            bool exists = false;

            foreach (User user in users)
            {
                if (username == user.Username)
                {
                    exists = true;
                }
            }

            return exists;
        }
    }
}
