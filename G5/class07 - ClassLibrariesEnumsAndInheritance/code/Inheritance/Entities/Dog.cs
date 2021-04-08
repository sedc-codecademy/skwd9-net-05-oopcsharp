using System;

namespace Entities
{
    public class Dog : Animal
    {
        public string Breed { get; set; }

        public Dog()
        {
            Console.WriteLine("A new instance of an Dog has been created. This is the Dog constructor!");
        }

        public void Bark() 
        {
            Console.WriteLine("Bark, Bark");
        }

    }
}
