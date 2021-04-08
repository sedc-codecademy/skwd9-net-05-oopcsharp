using System;

namespace SEDC.Class07.CSharpOop.ClassesRecap.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Here we use the default constructor to create an object
            Car bmw = new Car();
            bmw.Id = 1;
            bmw.CarName = "m3";
            bmw.CarBodyType = "Sedan";
            bmw.HorsePower = 200;
            bmw.StartCar();
            // Here we use the custom constructor to create an object
            Car citroen = new Car("Citroen C4", "Hatchback", 77);
            Car volvo = new Car("Volvo V70");
            bool isVolvoStarted = volvo.IsCarStarted();
            Console.WriteLine(isVolvoStarted);
            citroen.StartCar();
            bool isCitroenStarted = citroen.IsCarStarted();
            citroen.IfCarIsStartedPressGasPedal(isCitroenStarted);
            Console.ReadLine();
        }
    }
}
