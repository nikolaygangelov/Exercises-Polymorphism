using System;
using System.Collections.Generic;
using System.Text;
using VehiclesExtension.Models.Interfaces;

namespace VehiclesExtension.Models
{
    public abstract class Vehicle
    {
        private const double SummerConsumtionToAdd = 0;

        protected Vehicle(double fuelQuantity, double tankCapacity)
        {
            FuelQuantity = fuelQuantity;
            TankCapacity = tankCapacity;
        }

        public double FuelQuantity { get; set; }
        public double TankCapacity { get; set; }

        public override string ToString()
        {
            return $": {FuelQuantity:f2}";
        }
    }
}
