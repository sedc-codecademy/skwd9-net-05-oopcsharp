using Classes.Models;
using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //constructor -> new
            Person personPaul = new Person();
            //private
            //Console.WriteLine(personPaul._ssn);
            Console.WriteLine(personPaul.FirstName); //null
            //set
            personPaul.Age = 20;
            //set
            personPaul.FirstName = "Paul";
            //set
            personPaul.LastName = "Fischer";
            //personPaul.GenerateSSN(); -> private
            string descriptionPaul = personPaul.GetDescription();
            Console.WriteLine($"Description for Paul: {descriptionPaul}");


            //CONSTRUCTOR WITH PARAMETERS
            Person bob = new Person("Bob", "Peterson", 25);
            string descriptionBob = bob.GetDescription();
            Console.WriteLine($"Description for Bob: {descriptionBob}");

            //DEFAULT CONSTRUCTOR
            Product car = new Product();
            car.Name = "BMW";
            car.Price = 24566.7;
            car.Code = 123;

            Product pizza = new Product()
            {
                Code = 145,
                Price = 300,
                Name = "Margarita"
            };
            pizza.Buy(200);

            Console.ReadLine();
        }
    }
}
