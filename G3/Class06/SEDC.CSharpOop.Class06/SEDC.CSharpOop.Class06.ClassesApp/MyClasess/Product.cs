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

        // this private props will be modified only in Buy method
        // we will use this properties to check if the product is already bought
        private DateTime SoldOn { get; set; } // 01.01.0001 12.00.00 AM default time
        private bool IsBought { get; set; } // false default value

        // the default constructor will not be available for usage because we did not specify one
        // if we want to use default constructor we need to add one here
        //public Product()
        //{

        //}

        // here we specify constructor with params
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
