namespace Cars
{
    public class Car
    {
        public Car(string color, int wheelsCount)
        {
            Color = color;
            WheelsCount = wheelsCount;
        }

        public string Color { get; set; }
        public int WheelsCount { get; set; }
        public override string ToString()
        {
            return $"Car with color \"{Color}\" and wheels count = {WheelsCount}";
        }
    }
}
