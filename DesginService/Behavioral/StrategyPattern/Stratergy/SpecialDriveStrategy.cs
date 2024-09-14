namespace DesignService.Behavioral.StrategyPattern.Strategy;

public class SpecialDriveStrategy : IDriveStrategy
{
    public void drive()
    {
        Console.WriteLine("Special Drive Strategy");
    }
}
