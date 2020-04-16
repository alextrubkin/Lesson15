

namespace HomeWork_15.StorageVehicle
{ 
    public class Bycycle<T> : Car<T>
    {
        public Bycycle(string name, string id, Color color, decimal price) : base(name, id, color, price)
        {

        }
        public override TypeOfVehicle Type => TypeOfVehicle.Bicycle;
    }
}
