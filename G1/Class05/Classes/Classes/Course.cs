namespace Classes.Classes
{
    public class Course
    {
        public string Name { get; set; }
        public int NumberOfClasses { get; set; }
        private string Code { get; set; } = "SEDC";

        public string GetCourseInfo()
        {
            return $"{Code}: {Name} (Number of Classes: {NumberOfClasses})";
        }

        public void SetCode(string code)
        {
            Code = code.StartsWith("SEDC") ? code : string.Empty;
        }

        //public void SetName(string name)
        //{
        //    Name = name;
        //}

        //public void SetNumberOfClasses(int numberOfClasses)
        //{
        //    NumberOfClasses = numberOfClasses;
        //}
    }
}
