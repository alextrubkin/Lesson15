namespace HomeWork15
{
    public class Van<T> : Car<T>
    {
        public Van(string name, string number, Color color, T volumeTank) : base(name, number, color, volumeTank)
        {
        }
        public override TypeOfCar TypeOfCar => TypeOfCar.van;

        public override string ToString()
        {
            return base.ToString() + $"Type of car: {TypeOfCar,10}|";
        }
    }
}
