using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Class07.CSharpOop.ClassesRecap.ConsoleApp
{
    public class Car
    {
        //Default constructor
        public Car()
        {

        }

        public Car(string carName,string carBodyType,int horsePower)
        {
            this.CarName = carName;
            this.CarBodyType = carBodyType;
            this.HorsePower = horsePower;
        }

        public Car(string carName)
        {
            this.CarName = carName;
        }

        public int Id { get; set; }
        public string CarName { get; set; }
        public string CarBodyType { get; set; }
        public int HorsePower { get; set; }
        private bool IsStarted { get; set; }

        public void StartCar()
        {
            Console.WriteLine("The car is starting....");
            IsStarted = true;
        }

        public bool IsCarStarted()
        {
            return IsStarted;
        }
        public void IfCarIsStartedPressGasPedal(bool isCarStarted)
        {
            if (isCarStarted)
            {
                Console.WriteLine("Give more gas");
            }
            else
            {
                Console.WriteLine("Please start the car first");
            }
        }
    }
}
