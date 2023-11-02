using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot.Modals
{
    class Vehicle
    {
        public Vehicle(string num, DateTime inTime, VehicleType type)
        {
            number = num;
            InTime = inTime;
            vehicleType = type;
        }

        public string number { get; set; }
        public DateTime InTime { get; set; }
        public VehicleType vehicleType { get; set; }

    }
}
