using System;
using Classes.Classes;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Course basicCSharp = new Course();
            basicCSharp.Name = "Basic C#";
            basicCSharp.NumberOfClasses = 40;
            //Console.WriteLine($"Please enter {basicCSharp.Name} code:");
            //string basicCSharpCode = Console.ReadLine();
            ////basicCSharp.Code = ValidateCode(basicCSharpCode);
            //basicCSharp.SetCode(basicCSharpCode);

            //private usage
            //basicCSharp.SetName("Basic C#");
            //basicCSharp.SetNumberOfClasses(40);

            Course basicJavaScript = new Course();
            basicJavaScript.Name = "Basic JS";
            basicJavaScript.NumberOfClasses = 60;
            //Console.WriteLine($"Please enter {basicJavaScript.Name} code:");
            //string basicJavaScriptCode = Console.ReadLine();
            ////basicCSharp.Code = ValidateCode(basicJavaScriptCode);

            Course advanceJavaScript = new Course()
            {
                Name = "Advance JS",
                NumberOfClasses = 60,
            };

            //Console.WriteLine($"Please enter {advanceJavaScript.Name} code:");
            //string advanceJavaScriptCode = Console.ReadLine();
            ////if property is private (or the set method is private) we need another function that will set the property value
            //advanceJavaScript.SetCode(advanceJavaScriptCode);
            //if property is public we can assign vale
            //basicCSharp.Code = ValidateCode(advanceJavaScriptCode);

            Console.WriteLine(basicCSharp.GetCourseInfo());
            Console.WriteLine(basicJavaScript.GetCourseInfo());
            Console.WriteLine(advanceJavaScript.GetCourseInfo());


            //Constructors
            Human human = new Human();
            human.FirstName = "Test";
            human.LastName = "Test";
            human.Role = "Trainer";

            Human human2 = new Human("Risto", "Panchevski", "Trener");
            human2.Courses[0] = basicCSharp;
            Human student = new Human("StudentName", "StudentLastName");
            student.Courses[0] = basicJavaScript;
            student.Courses[1] = advanceJavaScript;

            Human student1 = new Human("Petko", "Petkovski", "Student",
                new Course[] {basicJavaScript, advanceJavaScript, basicCSharp});

            Console.WriteLine(human2.GetHumanInfo());
            Console.WriteLine(student.GetHumanInfo());
            Console.WriteLine(student1.GetHumanInfo());
        }

        //static string ValidateCode(string code)
        //{
        //    //if (code.StartsWith("SEDC")) return code;
        //    //return string.Empty;

        //    return code.StartsWith("SEDC") ? code : string.Empty;
        //}
    }
}
