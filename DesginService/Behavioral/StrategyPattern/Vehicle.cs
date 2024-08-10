using DesginService.Behavioral.StrategyPattern.Strategy;

namespace DesginService.Behavioral.StrategyPattern;

public class Vehicle
{
    IDriveStrategy driveStrategy;

    public Vehicle(IDriveStrategy driveStrategyObj)
    {
        driveStrategy = driveStrategyObj;
    }
    public void drive()
    {
        driveStrategy.drive();
    }
}
