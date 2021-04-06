using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpOop.Class06.ClassesApp.MyClasess
{
    public class Product
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        private DateTime SoldOn { get; set; } // 01.01.0001 12.00.00 AM default time
        private bool IsBought { get; set; } // false default value

        public Product(int code, string name, double price)
        {
            Code = code;
            Name = name;
            Price = price;
        }

        public void Buy(double money)
        {
            if (IsBought)
            {
                CheckIfProductIsBought();
            }
            else if(money >= Price)
            {
                SoldOn = DateTime.Now;
                IsBought = true;
                Console.WriteLine($"You just bought a {Name}");
            }
            else
            {
                Console.WriteLine($"You need {Price - money} more to buy this product!");
            }
        }

        public void CheckIfProductIsBought()
        {
            if(IsBought)
            {
                Console.WriteLine(string.Format("The product {0} was bought on {1}", Name, SoldOn));
            }
            else
            {
                Console.WriteLine(string.Format("The product {0} is still available", Name));
            }
        }
    }
}
