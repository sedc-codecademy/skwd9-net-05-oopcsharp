namespace Classes.Classes
{
    public class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public Course[] Courses { get; set; } = new Course[10];

        public Human()
        {
            //Courses = new Course[10];
        }

        public Human(string firstName, string lastName, string role)
        {
            FirstName = firstName;
            LastName = lastName;
            Role = role;
            //Courses = new Course[10];
        }

        public Human(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Role = "Student";
            //Courses = new Course[10];
        }

        public Human(string firstName, string lastName, string role, Course[] courses)
        {
            FirstName = firstName;
            LastName = lastName;
            Role = role;

            for (int i = 0; i < courses.Length; i++)
            {
                Courses[i] = courses[i];
            }
        }

        public string GetHumanInfo()
        {
            string info = $"{FirstName} {LastName} ({Role}):\n";

            for (int i = 0; i < Courses.Length; i++)
            {
                if(Courses[i] == null) continue;

                //info = info + $"{i + 1}. {Courses[i].GetCourseInfo()}\n";
                info += $"{i + 1}. {Courses[i].GetCourseInfo()}\n";
            }

            return info;
        }
    }
}
