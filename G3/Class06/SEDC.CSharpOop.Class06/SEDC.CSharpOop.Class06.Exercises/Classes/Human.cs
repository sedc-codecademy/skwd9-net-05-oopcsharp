using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpOop.Class06.Exercises.Classes
{
    public class Human
    {
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Age { get; set; }
		public string GetPersonStats()
		{
			return string.Format("Name:{0,20} Age:{1,6}", $"{FirstName} {LastName}", Age);
		}
	}
}
