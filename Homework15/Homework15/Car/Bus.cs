namespace Homework15
{
    public class Bus : Car
    {
        public Bus(string color, int price, string name) : base(color, price, name)
        {
            Color = color;
            Price = price;
            Name = name;
        }
        public override string Color { get; set; }

        public override int Price { get; set; }

        public override string Name { get; set; }

    }
}
