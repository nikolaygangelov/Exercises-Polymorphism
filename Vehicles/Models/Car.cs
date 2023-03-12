using System;
using System.Collections.Generic;
using System.Text;
using Vehicles.Models.Interfaces;

namespace Vehicles.Models
{
    public class Car : Vehicle, IVehicle
    {
        private const double SummerConsumtionToAdd = 0.9;

        public Car(double fuelQuantity, double fuelConsumption) :
            base(fuelQuantity, fuelConsumption)
        {

        }
        public override double EndConsumption => SummerConsumtionToAdd + FuelConsumption;
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
            FuelQuantity += liters;
        }

        public override string ToString()
        {
            return "Car" + base.ToString();
        }
    }
}
