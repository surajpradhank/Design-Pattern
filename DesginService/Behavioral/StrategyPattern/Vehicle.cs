using DesginService.Behavioral.StrategyPattern.Stratergy;

namespace DesginService.Behavioral.StrategyPattern;

public class Vehicle
{
    IDriveStratergy driveStratergy;

    public Vehicle(IDriveStratergy driveStratergyObj)
    {
        driveStratergy = driveStratergyObj;
    }
    public void drive()
    {
        driveStratergy.drive();
    }
}
