using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.MyClasses
{
    public class Product
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Person Person { get; set; }

        public void Buy(double money) 
        {
            if (money >= Price)
            {
                Console.WriteLine($"You just bought {Name}!");
            }
            else 
            {
                Console.WriteLine($"You need {Price - money} to buy this product!");
            }
        }
    }
}
