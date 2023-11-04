using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot.Modals
{
    class Vehicle
    {
        public Vehicle(string num, VehicleType type)
        {
            Number = num;
            Type = type;
        }

        public string Number { get; set; }
        public VehicleType Type { get; set; }
      
    }
}
