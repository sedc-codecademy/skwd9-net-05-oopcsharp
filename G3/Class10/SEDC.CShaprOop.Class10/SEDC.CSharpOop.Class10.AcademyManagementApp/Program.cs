using SEDC.CSharpOop.Class10.Bussines.Services;
using System;

namespace SEDC.CSharpOop.Class10.AcademyManagementApp
{
    class Program
    {
        static void Main(string[] args)
        {
            UserManagmentService userManagmentService = new UserManagmentService();

            bool isLogedIn = userManagmentService.Login();

            while (isLogedIn)
            {
                // doSomething
            }

            Console.ReadLine();
        }
    }
}
