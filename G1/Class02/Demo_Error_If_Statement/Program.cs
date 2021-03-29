using System;

namespace Demo_Error_If_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 Scenario
            int broj;
            string input = Console.ReadLine();

            if (input == "1")
            {
                broj = int.Parse(input);
            }
            else
            {
                Console.WriteLine("Error");
                return;
            }

            broj++;

            Console.WriteLine(broj);

            //2 Scenario
            string surname;
            if (input == "Risto")
            {
                surname = "Panchevski";
            }
            else
            {
                surname = "";
            }

            Console.WriteLine(surname);
        }
    }
}
