

namespace Exercise1
{
	public class Human
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Age { get; set; }
		public string GetPersonStats()
		{
			return $"{FirstName} {LastName}, age: {Age}";
		}
	}
}
