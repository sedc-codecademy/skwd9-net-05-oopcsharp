using System;
using System.Collections.Generic;
using System.Text;

namespace LoginApp.Classes
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string[] Messages { get; set; }
    }
}
