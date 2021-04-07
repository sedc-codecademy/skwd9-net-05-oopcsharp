namespace Inheritance.Classes
{
    public class Animal
    {
        //unique identification
        public int Id { get; set; }
        //animal name (Bark, Jack, Dambo)
        public string Name { get; set; }
        //animal type (Dog, Cat, Elephant)
        public string Type { get; set; }

        public Animal()
        {
        }
        
        public Animal(int id, string name, string type)
        {
            Id = id;
            Name = name;
            Type = type;
        }

        public virtual string Eat()
        {
            return $"The {Type} named {Name} is eating";
        }

        public string GetInfo()
        {
            return $"{Id} {Type} {Name}";
        }
    }
}
