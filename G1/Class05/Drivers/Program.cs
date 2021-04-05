using System;

namespace Drivers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Possible null reference
            //Car ferrari = new Car("Ferrari", 240);

            //int ferrariSpeed = ferrari.CalculateSpeed();

            //Console.WriteLine(ferrariSpeed);

            Car[] cars = new Car[4]
            {
                new Car("Hyundai", 200),
                new Car("Mazda", 220),
                new Car("Ferrari", 280),
                new Car("Porsche", 270)
            };
            
            Driver[] drivers = new Driver[4]
            {
                new Driver("Bob", 4),
                new Driver("Greg", 8),
                new Driver("Hamilton", 10),
                new Driver("Anne", 8)
            };

            Console.WriteLine("Select first car and driver");
            int firstCarIndex = SelectCar(cars);
            int firstDriverIndex = SelectDriver(drivers);

            Car firstCar = cars[firstCarIndex];
            Driver firstDriver = drivers[firstDriverIndex];
            firstCar.SetDriver(firstDriver);

            Console.WriteLine("Select second car and driver");
            int secondCarIndex = SelectCar(cars, firstCar);
            int secondDriverIndex = SelectDriver(drivers);

            if (firstCarIndex == secondCarIndex)
            {
                Console.WriteLine("ERROR: You have selected same car twice.");
                return;
            }

            if (firstDriverIndex == secondDriverIndex)
            {
                Console.WriteLine("ERROR: You have selected same driver twice.");
                return;
            }

            Car secondCar = cars[secondCarIndex];
            Driver secondDriver = drivers[secondDriverIndex];
            secondCar.SetDriver(secondDriver);

            Car winner = RaceCars(firstCar, secondCar);

            if (winner == null)
            {
                Console.WriteLine("Equal race!");
                return;
            }

            Console.WriteLine($"The winner is {winner.Driver.Name} with {winner.Model} with speed {winner.CalculateSpeed()}!");
        }

        static Car RaceCars(Car car1, Car car2)
        {
            if (car1.CalculateSpeed() > car2.CalculateSpeed())
                return car1;

            if (car2.CalculateSpeed() > car1.CalculateSpeed())
                return car2;

            return null;
        }

        static int SelectCar(Car[] cars, Car exclude = null)
        {
            while (true)
            {
                Console.WriteLine("Please select car, by choosing 1-4: ");

                for (int i = 0; i < cars.Length; i++)
                {
                    if (exclude != null && cars[i].Model == exclude.Model)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.ResetColor();
                    }

                    Console.WriteLine($"{i + 1}. {cars[i].Model}");
                }

                string selectedCarString = Console.ReadLine();

                bool success = int.TryParse(selectedCarString, out int selectedCar);

                if (!success || selectedCar > 4 || selectedCar < 1)
                {
                    Console.WriteLine("Wrong value selected");
                    continue;
                }

                return selectedCar - 1;
            }
        }

        static int SelectDriver(Driver[] drivers)
        {
            while (true)
            {
                Console.WriteLine("Please select driver, by choosing 1-4: ");

                for (int i = 0; i < drivers.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {drivers[i].Name}");
                }

                string selectedDriverString = Console.ReadLine();

                bool success = int.TryParse(selectedDriverString, out int selectedDriver);

                if (!success || selectedDriver > 4 || selectedDriver < 1)
                {
                    Console.WriteLine("Wrong value selected");
                    continue;
                }

                return selectedDriver - 1;
            }
        }
    }
}
