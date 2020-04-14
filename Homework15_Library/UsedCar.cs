namespace Homework15_Library
{
    public class UsedCar : Car
    {
        public override string CarType => "Used car";
        public int Mileage { get; private set; }


        public UsedCar(string name, int number, decimal price, int mileage) : base(name, number, price)
        {
            Mileage = mileage;
        }


        public override string ToString()
        {
            return base.ToString().Insert(base.ToString().IndexOf("price"), $"mileage: {Mileage}, "); ;
        }
    }
}
