namespace CarRacingApp.Domain
{
    public class Driver
    {
        public Driver(string name, int skill)
        {
            this.Name = name;
            this.Skill = skill;
        }
        public string Name { get; set; }
        public int Skill { get; set; }
    }
}
