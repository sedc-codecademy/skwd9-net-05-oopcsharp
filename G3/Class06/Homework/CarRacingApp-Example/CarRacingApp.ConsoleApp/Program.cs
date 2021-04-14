using System;
using RaceApp.Domain;

namespace CarRacingApp.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Driver[] drivers = new Driver[]
            {
                new Driver("Damjan",3),
                new Driver("Bob",5),
                new Driver("Jill",4),
                new Driver("Greg", 2)
            };

            Car[] cars = new Car[]
            {
                new Car("Toyota",230,drivers[1]),
                new Car("Renault",200,drivers[2]),
                new Car("Porche",320,drivers[3]),
                new Car("Citroen",240,drivers[0])
            };

            RaceCars(cars[0], cars[2]);

            Console.ReadLine();
        }

        static void RaceCars(Car car1, Car car2)
        {
            int carOneSpeed = car1.CalculateSpeed(car1.Vozac);
            int carTwoSpeed = car2.CalculateSpeed(car2.Vozac);

            if(carOneSpeed > carTwoSpeed)
            {
                Console.WriteLine($"The car {car1.CarModel} is faster");
            }
            else
            {
                Console.WriteLine($"The car {car2.CarModel} is faster");
            }
        }
    }
}
