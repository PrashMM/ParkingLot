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
        DateTime ticket = DateTime.Now;
        public void GenerateParkingTicket(Vehicle vehicle, List<Vehicle> WheelInfo, string val)
        {
            Console.WriteLine(Constants.seperateLine);
            Console.WriteLine(Constants.generateTicket);
            Console.WriteLine("******************************************");
            Console.WriteLine($"-> Vehicle Number = {vehicle.Number}");
            Console.WriteLine($"-> {vehicle.Type} Wheeler ");
            Console.WriteLine($"-> In Time = {ticket}");
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

        public void UnParkedVehicle(Vehicle vehicle)
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~----------------------");
            Console.WriteLine($"Okay, Vehicle Number {vehicle.Number} has been unparked from ParkingLot at {ticket}");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~----------------------");
        }
    }
}
