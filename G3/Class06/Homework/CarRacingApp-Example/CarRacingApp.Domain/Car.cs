namespace CarRacingApp.Domain
{
    public class Car
    {
        public Car(string carModel, int carSpeed, Driver racer)
        {
            this.CarModel = carModel;
            this.CarSpeed = carSpeed;
            this.Racer = racer;
        }
        public string CarModel { get; set; }
        public int CarSpeed { get; set; }
        public  Driver Racer { get; set; }

        public int CalculateSpeed(Driver driver)
        {
            return CarSpeed * driver.Skill;
        }
    }
}
