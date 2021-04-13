using System;
using System.Collections.Generic;
using System.Text;

namespace RaceApp.Domain
{
    public class Car
    {
        public Car(string carModel, int speed, Driver driver)
        {
            this.CarModel = carModel;
            this.Speed = speed;
            this.Vozac = driver;
        }
        public string CarModel { get; set; }
        public int Speed { get; set; }
        public Driver Vozac { get; set; }

        public int CalculateSpeed(Driver vozac)
        {
            return vozac.Skill * Speed;
        }
    }
}
