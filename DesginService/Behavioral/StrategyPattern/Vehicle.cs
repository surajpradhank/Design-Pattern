using DesignService.Behavioral.StrategyPattern.Strategy;

namespace DesignService.Behavioral.StrategyPattern;

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
