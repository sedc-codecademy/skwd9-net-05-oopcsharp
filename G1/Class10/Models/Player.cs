namespace Models
{
    public class Player : Human
    {
        public Position Position { get; set; }

        public Player(string firstName, string lastName, int age, Position position) : base(firstName, lastName, age)
        {
            Position = position;
        }
        public override string GetInfo()
        {
            return $"{base.GetInfo()} {Position}";
        }
    }
}
