
namespace HomeWork15
{
    public class Car<T>:Vehicle
    {
        private string _name;
        private string _number;
        public T _volumeTank;

        public Car(string name, string number, Color color, T volumeTank)
        {
            Name = name;
            Number = number;
            Color = color;
            _volumeTank = volumeTank;
        }

        private string TypeOfVehicle => "Car";
        public virtual TypeOfCar TypeOfCar { get; }
        public string Name
        {
            get => _name;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _name = value;
                }
            }
        }

        public string Number
        {
            get => _number;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _number = value;
                }
            }
        }


        public Color Color { get; set; }

        public override string ToString()
        {
            return $"Type of vehicle: {TypeOfVehicle,5}|\tName: {Name,10}|\tNumber: {Number,10}|\tColor: {Color,10}|\t Volume of tank: {_volumeTank,5}|";
        }
    }
}

