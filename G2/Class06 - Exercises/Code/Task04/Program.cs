using System;
using Task04.Classes;

namespace Task04
{
    class Program
    {
        static Customer FindCustomer(Customer [] customers, string cardNumber)
        {
            foreach(Customer customer in customers)
            {
                if(customer.CardNumber == cardNumber)
                {
                    return customer;
                }
            }
            return null;
        }
       
        static void Main(string[] args)
        {
            Customer[] customers = new Customer[] {
                new Customer("Bob","Bobsky", "1234123412341234", 1234, 750),
                new Customer("Jill","Wayne", "8235823582358235", 9000, 1200),
                new Customer("Rayan","Dawn", "0090119122923393", 2500, 500),
                new Customer("Anne","May", "0000220311012203", 0000, 400)
            };

            Console.WriteLine("Welcome to our ATM");
            Console.WriteLine("Enter card number");
            string cardNumber = Console.ReadLine();
            if (string.IsNullOrEmpty(cardNumber))
            {
                Console.WriteLine("You must enter card number");
            }
            else
            {
                Customer customer = FindCustomer(customers, cardNumber);
                if(customer == null)
                {
                    Console.WriteLine("Customer not found!");
                        return;
                }
                Console.WriteLine("Enter pin");
                bool success = int.TryParse(Console.ReadLine(), out int pin);
                if (success)
                {
                    if (customer.CheckPin(pin))
                    {

                    }
                    else
                    {
                        Console.WriteLine("Incorrect pin!");
                        return;
                    }
                }

            }

        }
    }
}
