// See https://aka.ms/new-console-template for more information
using DesginService.Behavioral;
using DesginService.Behavioral.StrategyPattern;

Console.WriteLine("Hello, World!");

Vehicle vehicle = new OffRoadVehicle();
vehicle.drive();

Vehicle vehicle1 = new GoodsVehicle();
vehicle1.drive();

Console.WriteLine("Thank you");

