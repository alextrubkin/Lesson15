

namespace HomeWork_15.StorageVehicle
{
    public class Truck<T> : Car<T>
    {
        public Truck(string name, string id, Color color, decimal price) : base(name, id, color, price)
        {

        }
        public override TypeOfVehicle Type => TypeOfVehicle.Truck;
    }
}
