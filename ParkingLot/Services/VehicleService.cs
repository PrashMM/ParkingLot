using ParkingLot.Modals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot.Services
{
    class VehicleService
    {
        private ParkingService parkingService;

        public VehicleService(ParkingService parkingService)
        {
            this.parkingService = parkingService;
        }
        OutputService iosService = new OutputService();
        public List<Vehicle> allVehicles { get; set; } = new List<Vehicle>();
        public List<Vehicle> twoWheelerVehicles { get; set; } = new List<Vehicle>();
        public List<Vehicle> threeWheelerVehicles { get; set; } = new List<Vehicle>();
        public List<Vehicle> moreWheelerVehicles { get; set; } = new List<Vehicle>();

        public void CheckVehicleCountInListToAdd(Vehicle vehicle)
        {
            allVehicles.Add(vehicle);
            switch (vehicle.vehicleType)
            {
                case VehicleType.TwoWheeler:
                    if (twoWheelerVehicles.Count <= 2)
                        parkingService.AddVehicle(twoWheelerVehicles, vehicle, "A");
                    else
                        iosService.NoSpaceinPark();
                       break;

                case VehicleType.ThreeWheeler:
                    if (threeWheelerVehicles.Count <= 2)
                       parkingService.AddVehicle(threeWheelerVehicles, vehicle, "B");
                    else
                        iosService.NoSpaceinPark();
                    break;

                case VehicleType.Heavy:
                    if (moreWheelerVehicles.Count <= 2)
                       parkingService.AddVehicle(moreWheelerVehicles, vehicle, "C");
                    else
                        iosService.NoSpaceinPark();
                    break;

                default:
                       break;
                 
            }
          
        }
      
        public void CheckVehicleExist(string number)
        {
           var vehicle = allVehicles.FirstOrDefault(vehicle => vehicle.number == number);
    
            if(vehicle == null)
            {
                iosService.VehicleNotParked();
            }
            else
            {
                CheckVehicleTypeToRemove(vehicle);
            }
           
        }

        public void CheckVehicleTypeToRemove(Vehicle vehicle)
        {

            allVehicles.Remove(vehicle);

            switch (vehicle.vehicleType)
            {
                case VehicleType.TwoWheeler:
                    parkingService.RemoveVehicle(twoWheelerVehicles, vehicle);
                    break;

                case VehicleType.ThreeWheeler:
                   parkingService.RemoveVehicle(threeWheelerVehicles, vehicle);
                    break;

                case VehicleType.Heavy:
                   parkingService.RemoveVehicle(moreWheelerVehicles, vehicle);
                    break;

                default:
                    break;
            }
            
        }

    }
}
