namespace Homework15
{
    public class Car
    {
        public Car(string color, int price, string name)
        {
            Color = color;
            Price = price;
            Name = name;
        }
        public string Color { get; set; }

        public int Price { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return $"Name Car {Name} has price {Price} and color {Color}";
        }
    }
}