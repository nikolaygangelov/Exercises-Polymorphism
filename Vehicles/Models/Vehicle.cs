using System;
using System.Collections.Generic;
using System.Text;
using Vehicles.Models.Interfaces;

namespace Vehicles.Models
{
    public abstract class Vehicle
    {
        private const double SummerConsumtionToAdd = 0;

        protected Vehicle(double fuelQuantity, double fuelConsumption)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }

        public double FuelQuantity { get; set; }

        public double FuelConsumption { get; set; }

        public virtual double EndConsumption => SummerConsumtionToAdd + FuelConsumption;

        public override string ToString()
        {
            return $": {FuelQuantity:f2}";
        }
    }
}
