using System;
using System.Collections.Generic;
using System.Text;

namespace ClassExercises
{
    public class Dog
    {
        public Dog()
        {

        }
        public string Name { get; set; }
        public string Breed { get; set; }
        public string Color { get; set; }

        public string Eat()
        {
            return "The dog is eating";
        }

        public string Play()
        {
            return "The dog is playing";
        }
        public string ChaseTail()
        {
            return "The dog is chaising its tail";
        }
    }
}
