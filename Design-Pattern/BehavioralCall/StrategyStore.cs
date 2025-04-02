using DesignService.Behavioral;
using DesignService.Behavioral.StrategyPattern;
using DesignService.Behavioral.StrategyPattern.Strategy;

namespace Design_Pattern.BehavioralCall
{
    internal static class StrategyStore
    {
        public static void validateStrategy()
        {
            Vehicle vehicle = new OffRoadVehicle(new SpecialDriveStrategy());
            vehicle.drive();

            Vehicle vehicle1 = new GoodsVehicle();
            vehicle1.drive();
        }
    }
}
