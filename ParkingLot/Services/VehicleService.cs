using ParkingLot.Data;
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
        //private ParkingService parkingService;

        //public VehicleService(ParkingService parkingService)
        //{
        //    this.parkingService = parkingService;
        //}
        OutputService outputService = new OutputService();
        ParkingLotData parkingLotData = new ParkingLotData();
        ParkingService parkingService = new ParkingService();
        //public List<Vehicle> allVehicles { get; set; } = new List<Vehicle>();
        //public List<Vehicle> twoWheelerVehicles { get; set; } = new List<Vehicle>();
        //public List<Vehicle> threeWheelerVehicles { get; set; } = new List<Vehicle>();
        //public List<Vehicle> moreWheelerVehicles { get; set; } = new List<Vehicle>();

        public void CheckVehicleCountInListToAdd(Vehicle vehicle)
        {
            parkingLotData.AllVehicles.Add(vehicle);
            switch (vehicle.Type)
            {
                case VehicleType.TwoWheeler:
                    if (parkingLotData.TwoWheelerVehicles.Count <= 2)
                        parkingService.ParkVehicle(parkingLotData.TwoWheelerVehicles, vehicle, "A");
                    else
                        outputService.NoSpaceinPark();
                       break;

                case VehicleType.ThreeWheeler:
                    if (parkingLotData.ThreeWheelerVehicles.Count <= 2)
                       parkingService.ParkVehicle(parkingLotData.ThreeWheelerVehicles, vehicle, "B");
                    else
                        outputService.NoSpaceinPark();
                    break;

                case VehicleType.Heavy:
                    if (parkingLotData.MoreWheelerVehicles.Count <= 2)
                       parkingService.ParkVehicle(parkingLotData.MoreWheelerVehicles, vehicle, "C");
                    else
                        outputService.NoSpaceinPark();
                    break;

                default:
                       break;
                 
            }
          
        }
      
       public void GetVehicleDetailsToUnpark(string number)
        {
           var vehicle = parkingLotData.AllVehicles.FirstOrDefault(vehicle => vehicle.Number == number);
    
            if(vehicle == null)
            {
                outputService.VehicleNotParked();            }
            else
            {
                CheckVehicleTypeToUnpark(vehicle);
            }
          }


        //var isExist = CheckVehicleExist(num);

        public void CheckVehicleTypeToUnpark(Vehicle vehicle)
        {

            parkingLotData.AllVehicles.Remove(vehicle);

            switch (vehicle.Type)
            {
                case VehicleType.TwoWheeler:
                    parkingService.UnParkVehicle(parkingLotData.TwoWheelerVehicles, vehicle);
                    break;

                case VehicleType.ThreeWheeler:
                   parkingService.UnParkVehicle(parkingLotData.ThreeWheelerVehicles, vehicle);
                    break;

                case VehicleType.Heavy:
                   parkingService.UnParkVehicle(parkingLotData.MoreWheelerVehicles, vehicle);
                    break;

                default:
                    break;
            }
            
        }

    }
}
