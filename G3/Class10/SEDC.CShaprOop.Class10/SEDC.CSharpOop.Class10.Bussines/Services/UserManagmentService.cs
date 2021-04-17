using SEDC.CSharpOop.Class10.Domain.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpOop.Class10.Bussines.Services
{
    public class UserManagmentService
    {
        private UserRepo UserRepo { get; set; }

        public UserManagmentService()
        {
            UserRepo = new UserRepo();
        }

        public bool Login()
        {
            Console.WriteLine("Please enter email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Please enter password: ");
            string password = Console.ReadLine();

            return true;
        }
    }
}
