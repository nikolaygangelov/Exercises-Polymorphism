using System;
using System.Collections.Generic;
using System.Text;
using VehiclesExtension.Models.Interfaces;

namespace VehiclesExtension.Models
{
    public class Car : Vehicle, IVehicle
    {
        private const double SummerConsumtionToAdd = 0.9;

        public Car(double fuelQuantity, double tankCapacity, double fuelConsumption) :
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
                Console.WriteLine($"Car travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Car needs refueling");
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
            return "Car" + base.ToString();
        }
    }
}
