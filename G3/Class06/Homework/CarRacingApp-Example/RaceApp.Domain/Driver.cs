using System;
using System.Collections.Generic;
using System.Text;

namespace RaceApp.Domain
{
    public class Driver
    {
        public Driver(string name, int skill)
        {
            this.Name = name;
            this.Skill = skill;
        }
        public string Name { get; set; }
        public int Skill { get; set; }
    }
}
