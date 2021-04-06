using SEDC.CSharpOop.Class06.Exercises.Classes;
using System;

namespace SEDC.CSharpOop.Class06.Exercises
{
    class Program
    {
		static Human GetHumanFromInput()
		{
			Human human = new Human();
			Console.Write("Enter human first name:");
			human.FirstName = Console.ReadLine();
			Console.Write("Enter human last name:");
			human.LastName = Console.ReadLine();
			Console.Write("Enter human age:");
			human.Age = int.Parse(Console.ReadLine());
			return human;
		}

		static void Main(string[] args)
        {
			#region Exercise 1
			Human inputHuman = GetHumanFromInput();
			Console.WriteLine(inputHuman.GetPersonStats());
			Console.ReadLine();
			#endregion
		}
	}
}
