using System;

namespace Entities
{
    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public Animal()
        {
            Console.WriteLine("A new instance of an Animal has been created. This is the Animal constructor!");
        }

        public Animal(string type)
        {
            Console.WriteLine("A new instance of an Animal has been created. This is the Animal second constructor!");
            Type = type;
        }

        // virtual method means that in the child entity that is inheriting from this parent entity, the metod marked with virtal can be re implemented
        // the method in the child entity can be overrided by using the key word "override"
        public virtual void Eat() 
        {
            Console.WriteLine($"The {Type} animal named {Name} is eating!");
        }

        public void PrintInfo() 
        {
            Console.WriteLine($"Id: {Id}, Animal:{Type}, Name: {Name}");
        }

    }
}
