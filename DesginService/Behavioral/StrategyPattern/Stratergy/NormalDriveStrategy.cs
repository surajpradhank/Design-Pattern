namespace DesignService.Behavioral.StrategyPattern.Strategy;

public class NormalDriveStrategy : IDriveStrategy
{
    public void drive()
    {
        Console.WriteLine("Normal Drive Strategy");
    }
}
