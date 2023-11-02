﻿using ParkingLot.Modals;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot.Services
{
    class ParkingService
    {

       private VehicleService vehicleService;

        public ParkingService(VehicleService vehicleService)
        {
            this.vehicleService = vehicleService;
        }

        OutputService outputService = new OutputService();
        
        public void AddVehicle(List<Vehicle> vehicleTypeList, Vehicle vehicle, String value)
        {
            vehicleTypeList.Add(vehicle);
            outputService.GenerateParkingTicket(vehicle, vehicleTypeList, value);
        }

        

        public void RemoveVehicle(List<Vehicle> vehicleTypeList, Vehicle vehicle)
        {
            vehicleTypeList.Remove(vehicle);
            outputService.VehicleRemoved(vehicle);
        }

    }
}
