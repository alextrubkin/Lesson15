
namespace HomeWork15
{
    public class Car
    {
        private string _name;

        private string _number;

        public Car(string name, string number, Color color)
        {
            Name = name;
            Number = number;
            Color = color;
        }

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

            private set
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
            return $"Name: {Name,10}|\tNumber: {Number,10}|\tColor: {Color,10}|";
        }
    }
}
