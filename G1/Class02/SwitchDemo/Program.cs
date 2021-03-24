using System;

namespace SwitchDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vnesi broj na den:");
            string dayString = Console.ReadLine();

            bool successParse = int.TryParse(dayString, out int dayNumber);

            if (!successParse)
            {
                Console.WriteLine("Invalid input");
                return;
            }

            switch (dayNumber)
            {
                case 1:
                    Console.WriteLine("Ponedelnik");
                    break;
                case 2:
                    Console.WriteLine("Vtornik");
                    break;
                case 3:
                    Console.WriteLine("Sreda");
                    break;
                default:
                    Console.WriteLine("Invalid day");
                    break;
            }
        }
    }
}
