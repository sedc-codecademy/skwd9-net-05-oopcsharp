namespace Inheritance.Classes
{
    public class Dog : Animal
    {
        public string Race { get; set; }

        public Dog()
        {
        }

        //public Dog(int id, string name)
        //{
        //    Id = id;
        //    Name = name;
        //    Type = "Dog";
        //}

        public Dog(int id, string name, string race) : base(id, name, "Dog")
        {
            Race = race;
        }

        public string Bark()
        {
            return $"{GetInfo()} Aw aw";
        }

        public override string Eat()
        {
            return $"Eating";
        }
    }
}
