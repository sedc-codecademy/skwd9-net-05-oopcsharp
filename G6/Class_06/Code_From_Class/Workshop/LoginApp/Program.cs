using LoginApp.Classes;
using System;

namespace LoginApp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            User[] users = GetUsers();
            while(true)
            {
                Console.WriteLine("Choose: \n1) Log in \n2)Register");
                bool isNumber = int.TryParse(Console.ReadLine(), out int choice);
                if (!isNumber)
                {
                    Console.WriteLine("That was not a number! Try Again!");
                    continue;
                }
                if (choice == 1)
                {
                    Console.Write("Enter Username: ");
                    string username = Console.ReadLine();
                    if (!ValidateCredential(username))
                    {
                        Console.WriteLine("You must enter username");
                        continue;
                    }
                    Console.Write("Enter password: ");
                    string password = Console.ReadLine();
                    if (!ValidateCredential(password))
                    {
                        Console.WriteLine("You must enter passwrod");
                        continue;
                    }
                    Login(users, username, password);
                    break;
                }
                if(choice == 2)
                {
                    Console.WriteLine("Enter Id:");
                    int id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter username");
                    string username = Console.ReadLine();
                    if (!ValidateCredential(username))
                    {
                        Console.WriteLine("You must enter username");
                        continue;
                    }
                    Console.WriteLine("Enter password:");
                    string password = Console.ReadLine();
                    if (!ValidateCredential(password))
                    {
                        Console.WriteLine("You must enter passwrod");
                        continue;
                    }
                    Register(users, username, password, id);
                    break;

                } else
                {
                    Console.WriteLine("You must insert 1 or 2");
                }

            }
           
        }

        static bool ValidateCredential(string input)
        {
            if (string.IsNullOrEmpty(input)) {
                return false;
            } else {
                return true;
            };
        }

        static void Register(User[] allUsers, string username, string password, int id)
        {
            User registeredUser = null;
            foreach (User user in allUsers)
            {
                if (user.Username == username)
                {
                    registeredUser = user;
                }
            }
            if (registeredUser != null)
            {
                Console.WriteLine("user already exists!");
            } else
            {
                User newUser = new User()
                {
                    Id = id,
                    Username = username,
                    Password = password,
                    Messages = new string[0]
                };
                Array.Resize(ref allUsers, allUsers.Length + 1);
                allUsers[allUsers.Length - 1] = newUser;
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("Registered Successfully");
                Console.WriteLine("----------------------------------------------");
                foreach (User user in allUsers)
                {
                    Console.WriteLine($"Id: {user.Id}, Username: {user.Username}");
                }

            }
        }

        static void Login(User[] allUsers, string userName, string password)
        {
            User loggedUser = null;
            foreach (User user in allUsers)
            {
                if (user.Username == userName && user.Password == password)
                {
                    loggedUser = user;
                }
            }

            if (loggedUser != null)
            {
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine($" Welcome {loggedUser.Username}");
                Console.WriteLine("Your messages: ");
                foreach (string message in loggedUser.Messages)
                {
                    Console.WriteLine($"   - {message}");
                }
            } else
            {
                Console.WriteLine("Invalid Credentials");
            }

        }

        static User[] GetUsers()
        {
            return new User[]
            {
                new User() {
                    Id = 1,
                    Username = "John123",
                    Password = "John321",
                    Messages = new string[]
                    {
                        "Hey John",
                        "How are you?",
                        "How old are you?"
                    }
                },
                new User() {
                    Id = 2,
                    Username = "Bob123",
                    Password = "Bob321",
                    Messages = new string[]
                    {
                        "Hey Bob",
                        "Call me please!",
                    }
                },
                new User() {
                    Id = 3,
                    Username = "Jane123",
                    Password = "Jane",
                    Messages = new string[]
                    {
                        "Where have you been yesterday?"
                    }
                },

            };
        }
    }
}
