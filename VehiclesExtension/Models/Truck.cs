using System;
using System.Collections.Generic;
using System.Text;
using VehiclesExtension.Models.Interfaces;

namespace VehiclesExtension.Models
{
    public class Truck : Vehicle, IVehicle
    {
        private const double SummerConsumtionToAdd = 1.6;
        private const double RefuelingLossPercent = 0.05;

        public Truck(double fuelQuantity, double tankCapacity, double fuelConsumption) : 
            base(fuelQuantity, tankCapacity)
        {
            FuelConsumption = fuelConsumption;
        }
        public double FuelConsumption { get; set; }
        public double EndConsumption => SummerConsumtionToAdd + FuelConsumption;

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
            if (liters > 0)
            {
                if (liters <= TankCapacity - FuelQuantity)
                {
                    FuelQuantity += liters - liters * RefuelingLossPercent;
                }
                else
                {
                    Console.WriteLine($"Cannot fit {liters} fuel in the tank");
                }
            }
            else
            {
                Console.WriteLine("Fuel must be a positive number");
            }
        }

        public override string ToString()
        {
            return "Truck" + base.ToString();
        }
    }
}
