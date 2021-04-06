using SEDC.CSharpOop.Class06.ClassesApp.MyClasess;
using System;

namespace SEDC.CSharpOop.Class06.ClassesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Trajan";
            person.Age = 33;
            // person.SSN = 1231231; // we cant access this becouse it is private;
            //person.Talk("Hello");

            //Console.WriteLine($"Hello my name is {person.Name} and im {person.Age} years old");

            // Creating an empty person object and immediately giving it values to the properties
            Person bill = new Person() { Name = "Bill Wurtz", Age = 31 }; // we don't need to set the properties
            //bill.Talk("Hello!");

            // Creating a person object using the second construvtor with parameters
            Person jill = new Person("Jill Wayne", 29);
            //jill.Talk("Bye!");

            // creating object using the only constructor specified
            // if we try to use the default constructor here we will not be able
            // if we want to use the default constructor here we will need to 
            // explicitly specify that constructor in Product class
            Product iceCream = new Product(1, "CokoLoko", 123);
            iceCream.CheckIfProductIsBought();
            iceCream.Buy(100);
            iceCream.Buy(200);
            iceCream.CheckIfProductIsBought();

            Product toyota = new Product(2, "Corola", 12000);
            toyota.CheckIfProductIsBought();
            toyota.Buy(20000);
            toyota.CheckIfProductIsBought();



            Console.ReadLine();
        }
    }
}
