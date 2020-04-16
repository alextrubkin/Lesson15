using System;

namespace HomeWork_15
{
    public abstract class Car<T>
    {
        private string _name;
        private string _id;
        private decimal _price = 1;
        
        public Car(string name, string id, Color color, decimal price)
        {
            Name = name;
            Id = id;
            Color = color;
            Price = price;            
        }
        public virtual TypeOfVehicle Type { get; }
        
      
        public string Name
        {
            get => _name;
            set
            {
                if (value != string.Empty)
                {
                    _name = value;
                }
            }
        }
        public string Id
        {
            get => _id;
            set
            {
                if (value != string.Empty)
                {
                    _id = value;
                }
            }
        }
        public Color Color { get; set; }
        public decimal Price
        {
            get => _price;
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
                else
                {
                    Console.WriteLine($"Hey,this price is invalid{value}!!!");
                }
            }
        }
        public override string ToString()
        {
            return $"|Type vehicle: {Type.ToString()}|\n\n name: {Name} with ID {Id}, Color: {Color} and Price {Price}";
        }       
    }   
}
