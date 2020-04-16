
namespace HomeWork_15.StorageVehicle
{    
    public class Minivan<T> : Car<T>
    {
        public Minivan(string name, string id, Color color, decimal price) : base(name, id, color, price)
        {

        }
        public override TypeOfVehicle Type => TypeOfVehicle.Minivan;
    }
}
