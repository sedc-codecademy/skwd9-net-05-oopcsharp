namespace Inheritance.Classes
{
    public class Tiger : Cat
    {
        public Tiger(string lazyness, string fatLevel, int id, string name) : base(lazyness, fatLevel, id, name)
        {

        }

        public override string Meow()
        {
            return $"{Name} roar roar";
        }
    }
}
