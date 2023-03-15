using System;
using System.Collections.Generic;
using System.Text;
using VehiclesExtension.Models.Interfaces;

namespace VehiclesExtension.Models
{
    public class Bus : Vehicle, IVehicle
    {
        public Bus(double fuelQuantity, double tankCapacity, double fuelConsumption) :
            base(fuelQuantity, tankCapacity)
        {
            FuelConsumption = fuelConsumption;
        }

        public double FuelConsumption { get; set; }

        public void Drive(double distance)
        {
            if (FuelQuantity >= FuelConsumption * distance)
            {
                FuelQuantity -= FuelConsumption * distance;
                Console.WriteLine($"Bus travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Bus needs refueling");
            }
        }

        public void Refuel(double liters)
        {
            if (liters > 0)
            {
                if (liters <= TankCapacity - FuelQuantity)
                {
                    FuelQuantity += liters;
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
            return "Bus" + base.ToString();
        }
    }
}
