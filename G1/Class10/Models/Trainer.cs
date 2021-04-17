namespace Models
{
    public class Trainer : Human
    {
        public int Experience { get; set; }

        public Trainer(string firstName, string lastName, int age, int experience) : base(firstName, lastName, age)
        {
            Experience = experience;
        }

        public override string GetInfo()
        {
            return $"{base.GetInfo()} Experience {Experience}";
        }
    }
}
