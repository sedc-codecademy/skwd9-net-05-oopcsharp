namespace Drivers
{
    public class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }
        public Driver Driver { get; set; }

        public Car()
        {
        }

        public Car(string model, int speed)
        {
            Model = model;
            Speed = speed;
        }

        public void SetDriver(Driver driver)
        {
            Driver = driver;
        }

        public int CalculateSpeed()
        {
            //return Speed * Driver?.Skill ?? 0;
            return Driver != null ? Speed * Driver.Skill : 0;
        }
    }
}
