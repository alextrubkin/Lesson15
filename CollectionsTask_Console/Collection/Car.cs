namespace CollectionsTask_Console.Collection
{
    public class Car
    {
        private int _maxSpeed = 100;

        public Car(string name, string color, int maxSpeed)
        {
            Name = name;
            Color = color;
            MaxSpeed = maxSpeed;
        }

        public string Name { get; set; }

        public string Color { get; set; }

        public int MaxSpeed
        {
            get => _maxSpeed;
            set
            {
                if (value > 0)
                {
                    _maxSpeed = value;
                }
            }
        }

        public override string ToString()
        {
            return $"{Color} {Name}, can go up to {MaxSpeed} km/hour";
        }
    }
}
