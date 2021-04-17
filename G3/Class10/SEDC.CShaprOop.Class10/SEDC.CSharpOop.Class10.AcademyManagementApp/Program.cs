using SEDC.CSharpOop.Class10.Bussines.ServiceModels;
using SEDC.CSharpOop.Class10.Bussines.Services;
using System;

namespace SEDC.CSharpOop.Class10.AcademyManagementApp
{
    class Program
    {
        static void Main(string[] args)
        {
            UserManagmentService userManagmentService = new UserManagmentService();
            AdminManagmentService adminManagmentService = new AdminManagmentService();

            UserResult userResult = userManagmentService.Login();

            Console.WriteLine(userResult.IsLoggedIn);
            if(userResult.Admin != null)
            {
                while (userResult.IsLoggedIn)
                {
                    AdminMenu();
                    // parse console inputt
                    bool isValid = int.TryParse(Console.ReadLine(), out int selectiion);
                    switch (selectiion)
                    {
                        case 1:
                            adminManagmentService.AddNewUser();
                            break;
                        case 2:
                            adminManagmentService.RemoveUser();
                            break;
                        default:
                            break;
                    }
                    // doSomething
                }
            }
            else if(userResult.Student != null)
            {
                while (userResult.IsLoggedIn)
                {
                    // doSomething
                }
            }
            else if(userResult.Trainer != null)
            {
                while (userResult.IsLoggedIn)
                {
                    // doSomething
                }
            }
            else
            {
                Console.WriteLine("Something bad has happend");
            }


            Console.ReadLine();
        }

        public static void AdminMenu()
        {
            Console.WriteLine("This is admin menu");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
