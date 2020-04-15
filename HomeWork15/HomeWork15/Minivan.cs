namespace HomeWork15
{
    public class Minivan<T> : Car<T>
    {
        public Minivan(string name, string number, Color color, T volumeTank) : base(name, number, color, volumeTank)
        {

        }
        private TypeOfCar TypeOfCar => TypeOfCar.minivan;

        public override string ToString()
        {
            return base.ToString() + $"Type of car: {TypeOfCar,10}|";
        }
    }
}
