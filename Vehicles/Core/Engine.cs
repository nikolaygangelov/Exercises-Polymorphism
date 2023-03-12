using System;
using System.Collections.Generic;
using System.Text;
using Vehicles.Core.Interfaces;
using Vehicles.Models;
using Vehicles.Models.Interfaces;

namespace Vehicles.Core
{
    public class Engine : IEngine
    {
        public void Run()
        {
            IVehicle car = null;
            IVehicle truck = null;
            for (int i = 0; i < 2; i++)
            {
                string[] vehicleInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                double vehicleFuelQuantity = double.Parse(vehicleInfo[1]);
                double vehicleLitersPerKm = double.Parse(vehicleInfo[2]);

                if (i == 0)
                {
                    car = new Car(vehicleFuelQuantity, vehicleLitersPerKm);
                }
                else
                {
                    truck = new Truck(vehicleFuelQuantity, vehicleLitersPerKm);
                }
            }


            int numberOfCommands = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] commandArgs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string commandType = commandArgs[0];
                string vehicleType = commandArgs[1];

                if (commandType == "Drive")
                {
                    if (vehicleType == "Car")
                    {
                        car.Drive(double.Parse(commandArgs[2]));
                    }
                    else if (vehicleType == "Truck")
                    {
                        truck.Drive(double.Parse(commandArgs[2]));
                    }
                }
                else if (commandType == "Refuel")
                {
                    if (vehicleType == "Car")
                    {
                        car.Refuel(double.Parse(commandArgs[2]));
                    }
                    else if (vehicleType == "Truck")
                    {
                        truck.Refuel(double.Parse(commandArgs[2]));
                    }
                }
            }

            Console.WriteLine(car.ToString());
            Console.WriteLine(truck.ToString());
        }
    }
}
