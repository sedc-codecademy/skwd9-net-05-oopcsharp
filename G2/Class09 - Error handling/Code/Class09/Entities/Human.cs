using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Skill> Skills { get; set; }
    }
}
