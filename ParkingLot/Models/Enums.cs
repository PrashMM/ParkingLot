using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot.Modals
{
    public enum MainMenu
    {
        ToParkVehicle=1,
        ToRemoveVehicle,
        None
    }

    public enum VehicleType
    {
        TwoWheeler,
        ThreeWheeler,
        Heavy
    }

    public enum WheelParkingDetails
    {
        ParkingInfo,
        TwoWheelerParking,
        ThreeWheelerParking,
        MoreWheelerParking,
        None 
    }

}
