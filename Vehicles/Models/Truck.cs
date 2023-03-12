using System;
using System.Collections.Generic;
using System.Text;
using Vehicles.Models.Interfaces;

namespace Vehicles.Models
{
    public class Truck : Vehicle, IVehicle
    {
        private const double SummerConsumtionToAdd = 1.6;
        private const double RefuelingLossPercent = 0.05;

        public Truck(double fuelQuantity, double fuelConsumption) : 
            base(fuelQuantity, fuelConsumption)
        {

        }
        public override double EndConsumption => SummerConsumtionToAdd + FuelConsumption;

        public void Drive(double distance)
        {

            if (FuelQuantity >= EndConsumption * distance)
            {
                FuelQuantity -= EndConsumption * distance;
                Console.WriteLine($"Truck travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Truck needs refueling");
            }
        }

        public void Refuel(double liters)
        {
            FuelQuantity += liters - liters * RefuelingLossPercent;
        }

        public override string ToString()
        {
            return "Truck" + base.ToString();
        }
    }
}
