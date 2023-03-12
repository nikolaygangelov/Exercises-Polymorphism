using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Models.Interfaces
{
    public interface IVehicle
    {
        void Drive(double distance);
        void Refuel(double liters);
    }
}
