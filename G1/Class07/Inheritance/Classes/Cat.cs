namespace Inheritance.Classes
{
    public class Cat : Animal
    {
        public string Lazyness { get; set; }
        public string FatLevel { get; set; }

        public Cat(string lazyness, string fatLevel, int id, string name) : base(id, name, "Cat")
        {
            Lazyness = lazyness;
            FatLevel = fatLevel;
        }

        public Cat()
        {

        }

        public virtual string Meow()
        {
            return $"{Name} Meow meow";
        }
    }
}
