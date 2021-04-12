using System;
using System.Collections.Generic;
using System.Text;
using AcademyLibrary.Enums;
using AcademyLibrary.Models;

namespace AcademyServices
{
    public static class ParticipantHelper
    {
        // if all members are static, that class becomes static
        // does not instantiate with new

        // A C# static class is a class that can't be instantiated. 
        // A static class can contain static members only. 
        // You can‘t create an object for the static class.
        // We do not use the NEW keyword.
        public static void FindParticipantByRole(AcademyRole role, Participant[] participants)
        {
            foreach (Participant item in participants)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                if(item.Role == role)
                {
                    item.PrintInfo();
                }
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }

    }
}
