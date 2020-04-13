using System;
using System.Collections.Generic;
using System.Text;

namespace HW1104
{
    public class Car
    {
        public Car(string mark, string model, double engineVolume, string fuelType)
        {
            Mark = mark;
            Model = model;
            EngineVolume = engineVolume;
            FuelType = fuelType;
        }
        public string Mark { get; set; }
        public string Model { get; set; }
        public double EngineVolume { get; set; }
        public string FuelType { get; set; }

        public override string ToString()
        {
            return $"{Mark}, {Model}, {EngineVolume}, {FuelType}";
        }
    }
}
