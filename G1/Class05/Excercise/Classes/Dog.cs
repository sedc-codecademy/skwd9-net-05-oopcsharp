namespace Excercise.Classes
{
    public class Dog
    {
        public string Name { get; set; }
        public string Race { get; set; }
        public string Color { get; set; }

        public Dog(string name, string race, string color)
        {
            Name = name;
            Race = race;
            Color = color;
        }

        public Dog()
        {

        }

        public string Eat()
        {
            return $"The dog {Name} is now eating.";
        }
        public string Play()
        {
            return $"The dog {Name} is now playing.";
        }
        public string ChaseTail()
        {
            return $"Dog {Name} is now chasing its tail.";
        }
    }
}
