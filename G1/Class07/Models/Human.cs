using System;

namespace Models
{
    public class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public Days DayOfTheWeek { get; set; }

        public Human()
        {

        }

        public Human(string firstName, string lastName, DateTime birthday, Days dayOfTheWeek)
        {
            FirstName = firstName;
            LastName = lastName;
            Birthday = birthday;
            DayOfTheWeek = dayOfTheWeek;
        }

        public string GetInfo()
        {
            var info = $"{Birthday.ToString("dd.MM.yyyy")} {DayOfTheWeek}";

            if (DayOfTheWeek == Days.Sat || DayOfTheWeek == Days.Sun)
            {
                info = $"{Birthday.ToString("dd.MM.yyyy")} weekend";
            }

            return info;
        }
    }
}
