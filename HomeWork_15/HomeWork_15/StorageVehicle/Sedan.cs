

namespace HomeWork_15.StorageVehicle
{
    public class Sedan<T>:Car<T>
    {
        public Sedan(string name, string id, Color color, decimal price) : base(name, id, color, price)
        {

        }
        public override TypeOfVehicle Type => TypeOfVehicle.Sedan;
    }
}
