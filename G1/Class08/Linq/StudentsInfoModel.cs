namespace Linq
{
    public class StudentsInfoModel
    {
        public string FullName { get; set; }
        public int Age { get; set; }

        public StudentsInfoModel()
        {
            
        }

        public StudentsInfoModel(string fullName, int age)
        {
            FullName = fullName;
            Age = age;
        }
    }
}
