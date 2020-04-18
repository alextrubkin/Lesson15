namespace HomeWork15
{
    public class Pickup<T> : Car<T>
    {
        public Pickup(string name, string number, Color color, T volumeTank) : base(name, number, color, volumeTank)
        {
        }
        public override TypeOfCar TypeOfCar => TypeOfCar.pickup;

        public override string ToString()
        {
            return base.ToString() + $"Type of car: {TypeOfCar,10}|";
        }
    }
}
