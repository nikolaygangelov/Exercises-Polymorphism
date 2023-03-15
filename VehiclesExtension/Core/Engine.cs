using System;
using System.Collections.Generic;
using System.Text;
using VehiclesExtension.Core.Interfaces;
using VehiclesExtension.Models;
using VehiclesExtension.Models.Interfaces;

namespace VehiclesExtension.Core
{
    public class Engine : IEngine
    {
        public void Run()
        {
            IVehicle car = null;
            IVehicle truck = null;
            IVehicle bus = null;
            for (int i = 0; i < 3; i++)
            {
                string[] vehicleInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                double vehicleFuelQuantity = double.Parse(vehicleInfo[1]);
                double vehicleLitersPerKm = double.Parse(vehicleInfo[2]);
                double tankCapacity = double.Parse(vehicleInfo[3]);

                if (vehicleInfo[0] == "Car")
                {
                    if (vehicleFuelQuantity <= tankCapacity)
                    {
                        car = new Car(vehicleFuelQuantity, tankCapacity, vehicleLitersPerKm);
                    }
                    else
                    {
                        vehicleFuelQuantity = 0;
                        car = new Car(vehicleFuelQuantity, tankCapacity, vehicleLitersPerKm);
                    }
                }
                else if (vehicleInfo[0] == "Truck")
                {
                    if (vehicleFuelQuantity <= tankCapacity)
                    {
                        truck = new Truck(vehicleFuelQuantity, tankCapacity, vehicleLitersPerKm);
                    }
                    else
                    {
                        vehicleFuelQuantity = 0;
                        truck = new Truck(vehicleFuelQuantity, tankCapacity, vehicleLitersPerKm);
                    }
                }
                else if (vehicleInfo[0] == "Bus")
                {
                    if (vehicleFuelQuantity <= tankCapacity)
                    {
                        bus = new Bus(vehicleFuelQuantity, tankCapacity, vehicleLitersPerKm);
                    }
                    else
                    {
                        vehicleFuelQuantity = 0;
                        bus = new Bus(vehicleFuelQuantity, tankCapacity, vehicleLitersPerKm);
                    }
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
                    else if (vehicleType == "Bus")
                    {
                        bus.FuelConsumption += 1.4;
                        bus.Drive(double.Parse(commandArgs[2]));
                        bus.FuelConsumption -= 1.4;
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
                    else if (vehicleType == "Bus")
                    {
                        bus.Refuel(double.Parse(commandArgs[2]));
                    }
                }
                else if (commandType == "DriveEmpty")
                {
                    bus.Drive(double.Parse(commandArgs[2]));
                }
            }

            Console.WriteLine(car.ToString());
            Console.WriteLine(truck.ToString());
            Console.WriteLine(bus.ToString());
        }
    }
}
