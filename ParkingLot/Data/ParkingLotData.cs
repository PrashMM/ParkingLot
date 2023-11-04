using ParkingLot.Modals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot.Data
{
    class ParkingLotData
    {
        public List<Vehicle> AllVehicles { get; set; } = new List<Vehicle>();
        public List<Vehicle> TwoWheelerVehicles { get; set; } = new List<Vehicle>();
        public List<Vehicle> ThreeWheelerVehicles { get; set; } = new List<Vehicle>();
        public List<Vehicle> MoreWheelerVehicles { get; set; } = new List<Vehicle>();
    }
}
