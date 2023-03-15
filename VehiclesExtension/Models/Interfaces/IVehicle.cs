using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesExtension.Models.Interfaces
{
    public interface IVehicle
    {
        double FuelConsumption { get; set; }

        void Drive(double distance);
        void Refuel(double liters);
    }
}
