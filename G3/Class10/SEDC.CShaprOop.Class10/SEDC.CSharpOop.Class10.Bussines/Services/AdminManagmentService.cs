using SEDC.CSharpOop.Class10.Domain.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpOop.Class10.Bussines.Services
{
    public class AdminManagmentService
    {
        private UserRepo UserRepo { get; set; }
        private SubjectRepo SubjectRepo { get; set; }

        public AdminManagmentService()
        {
            UserRepo = new UserRepo();
            SubjectRepo = new SubjectRepo();
        }

        // admin managment stuff
        public void AddNewUser()
        {
            // whole logic for adding new user
        }

        public void RemoveUser()
        {
            // whole logic for remove new user
        }
    }
}
