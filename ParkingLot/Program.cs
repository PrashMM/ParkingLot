// See https://aka.ms/new-console-template for more information

using ParkingLot.Modals;
using ParkingLot.Services;


namespace ParkingLot
{
    class Program
    {

        public static void Main()
        {
            WelcomeMenu();
        }

        public static void WelcomeMenu()
        {
            Console.WriteLine(Constants.welcomeMessage);

            ParkingService parkingService = new ParkingService(new VehicleService(null));
            VehicleService vehicleService = new VehicleService(parkingService);
            Console.WriteLine(Constants.chooseParkingOptions);

            var userInput = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                try
                {
                    switch (GetMainMenuByInput(userInput))
                    {
                        case MainMenu.ToParkVehicle:

                            Console.WriteLine(Constants.vehicleWheelInfo);
                            var wheelNum = int.Parse(Console.ReadLine());
                            Console.WriteLine(Constants.seperateLine);
                            Console.WriteLine(Constants.enterVehicleNumber);
                            var number = Console.ReadLine();
                            var inTime = DateTime.Now;

                            switch (GetWheelDetails(wheelNum))
                            {
                                case WheelParkingDetails.ParkingInfo:
                                    Console.WriteLine(Constants.welcomeMessage);
                                    break;

                                case WheelParkingDetails.TwoWheelerParking:
                                    var newTwoWheelerVehicle = new Vehicle(number, inTime, VehicleType.TwoWheeler);
                                    vehicleService.CheckVehicleCountInListToAdd(newTwoWheelerVehicle);
                                    break;

                                case WheelParkingDetails.ThreeWheelerParking:
                                    var newThreeWheelerVehicle = new Vehicle(number, inTime, VehicleType.ThreeWheeler);
                                    vehicleService.CheckVehicleCountInListToAdd(newThreeWheelerVehicle);
                                    break;

                                case WheelParkingDetails.MoreWheelerParking:
                                    var newMoreWheelerVehicle = new Vehicle(number, inTime, VehicleType.Heavy);
                                    vehicleService.CheckVehicleCountInListToAdd(newMoreWheelerVehicle);
                                    break;

                                default:
                                    Console.WriteLine(Constants.selectValidOption);
                                    break;
                            }
                        break;

                        case MainMenu.ToRemoveVehicle:
                            Console.WriteLine(Constants.enterVehicleNumber);
                            var num = Console.ReadLine();
                            vehicleService.CheckVehicleExist(num);
                            break;

                        default:
                            Console.WriteLine(Constants.selectValidOption);
                            break;
                    }

                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                Console.WriteLine(Constants.continueOrExit);
                var value = Console.ReadLine();

                if (value == "X" || value == "x")
                    return;
                else
                    Console.WriteLine(Constants.chooseParkingOptions);
                    userInput = Convert.ToInt32(Console.ReadLine());
                
            }
        }
    

      public static MainMenu GetMainMenuByInput(int value)
      {
            if (value == 1)
                return MainMenu.ToParkVehicle;
            else if (value == 2)
                return MainMenu.ToRemoveVehicle;
            else 
                return default;
      
      }


        public static WheelParkingDetails GetWheelDetails(int wheelNum)
        {
            if (wheelNum == 1)
                return WheelParkingDetails.ParkingInfo;
            else if (wheelNum == 2)
                return WheelParkingDetails.TwoWheelerParking;
            else if (wheelNum == 3)
                return WheelParkingDetails.ThreeWheelerParking;
            else if (wheelNum == 4)
                return WheelParkingDetails.MoreWheelerParking;
            else
                return default;
        }

    }
}
