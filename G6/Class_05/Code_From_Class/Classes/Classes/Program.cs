using Classes.MyClasses;
using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person john = new Person("John", 32);
            john.Talk("Classes are awosome!");

            Person bob = new Person();
            bob.Name = "Bob";
            bob.Age = 33;
            bob.Talk("Yes, they are!");

            Person jane = new Person()
            {
                Name = "Jane",
                Age = 23
            };
            
            jane.Talk("This approach is called object initializer");

            Product product1 = new Product()
            {
                Name = "PRODUCT NAME",
                Code = 123123123,
                Price = 25
            };
            product1.Buy();
            Console.ReadLine();
        }
    }
}
