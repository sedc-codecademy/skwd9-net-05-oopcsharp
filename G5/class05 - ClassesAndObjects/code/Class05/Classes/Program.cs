using System;
using Classes.MyClasses;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Viktor";
            person.Age = 31;

            person.Talk("Hello there!");

            Person person2 = new Person("Angela", 25);
            person2.Talk("Hi there!");


            Product car = new Product()
            {
                Code = 11902,
                Name = "Car",
                Price = 25500,
                Person = person
            };

            Console.WriteLine(car.Name);
            Console.WriteLine(car.Price);
            Console.WriteLine(car.Person.Name);

            car.Buy(35000);



            Console.ReadLine();
        }
    }
}
