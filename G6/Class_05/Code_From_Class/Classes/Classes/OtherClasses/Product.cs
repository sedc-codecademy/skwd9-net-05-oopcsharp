using System;
using System.Collections.Generic;
using System.Text;

namespace Classes // We change the namespace and now its living in classes address
{
    class Product
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public void Buy()
        {
            Console.WriteLine("You have bought this product!");
        }
    }
}
