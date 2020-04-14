namespace Homework15_Library
{
    public class Car
    {
        public virtual string CarType { get; } = "New car";
        public string Name { get; private set; }
        public int ID { get; private set; }
        public decimal Price { get; private set; }


        public Car(string name, int number, decimal price)
        {
            Name = name;
            ID = number;
            Price = price;
        }


        public override string ToString()
        {
            return $"Name: {Name}, ID: {ID:d3}, price: {Price} $.";
        }
    }

}
