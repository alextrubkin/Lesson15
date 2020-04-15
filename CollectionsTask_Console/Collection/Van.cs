namespace CollectionsTask_Console.Collection
{
    public class Van : Car
    {
        public Van(string name, string color, int maxSpeed)
            : base(name, color, maxSpeed)
        {
            Name = name;
            Color = color;
            MaxSpeed = maxSpeed;
        }
    }
}
