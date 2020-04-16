

namespace HomeWork_15.StorageVehicle
{
    public class Van<T> : Car<T>
    {
        public Van(string name, string id, Color color, decimal price) : base(name, id, color, price)
        {

        }
        public override TypeOfVehicle Type => TypeOfVehicle.Van;
    }
}
