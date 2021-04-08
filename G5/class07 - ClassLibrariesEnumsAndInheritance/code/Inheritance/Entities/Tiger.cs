using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Tiger : Cat
    {
        public override void Meow() 
        {
            Console.WriteLine("Roar roar");
        }
    }
}
