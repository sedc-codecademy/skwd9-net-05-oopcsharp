using System;
using AcademyLibrary.Models;
using AcademyLibrary.Enums;
using AcademyServices;

namespace AcademyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Participant trainer = new Participant("Kristina", "Spasevska", 34, AcademyRole.Trainer);
            Participant assistant = new Participant("Panche", "Manaskov", 21, AcademyRole.Assistant);
            Participant student01 = new Participant("Ceca", "Vasileva", 18, AcademyRole.Student);
            Participant student02 = new Participant("Ivan", "Jamandilov", 22, AcademyRole.Student);

            Participant[] academyParticipants = new Participant[]
            {
                trainer,
                assistant,
                student01,
                student02
            };

            // using helper service class  with static method
            // we do not instantiate with new
            
            ParticipantHelper.FindParticipantByRole(AcademyRole.Trainer, academyParticipants);

            Console.ReadLine();
        }
    }
}
