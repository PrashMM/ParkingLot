using ParkingLot.Modals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot.Services
{
     class OutputService
    {
        public void GenerateParkingTicket(Vehicle vehicle, List<Vehicle> WheelInfo, string val)
        {
            Console.WriteLine(Constants.seperateLine);
            Console.WriteLine(Constants.generateTicket);
            Console.WriteLine("******************************************");
            Console.WriteLine($"-> Vehicle Number = {vehicle.number}");
            Console.WriteLine($"-> {vehicle.vehicleType} Wheeler ");
            Console.WriteLine($"-> In Time = {vehicle.InTime}");
            Console.WriteLine($"-> Parking Area :- {val}{WheelInfo.Count}");
            Console.WriteLine("*******************************************");
        }

        public void NoSpaceinPark()
        {
            Console.WriteLine(Constants.seperateLine);
            Console.WriteLine(Constants.noSpaceAvailable);
            Console.WriteLine(Constants.seperateLine);

        }

        public void VehicleNotParked()
        {
            Console.WriteLine(Constants.vehicleNotParked);
        }

        public void VehicleRemoved(Vehicle vehicle)
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~----------------------");
            Console.WriteLine($"Okay, Vehicle Number {vehicle.number} has been removed from the parking at {DateTime.Now}");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~----------------------");
        }
    }
}
