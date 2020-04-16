
namespace HomeWork_15.StorageVehicle
{    
    public class Tank<T> : Car<T>
    {
        public Tank(string name, string id, Color color, decimal price) : base(name, id, color, price)
        {

        }
        public override TypeOfVehicle Type => TypeOfVehicle.Tank;
    }
}
