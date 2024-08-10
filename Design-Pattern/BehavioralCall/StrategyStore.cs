using DesginService.Behavioral;
using DesginService.Behavioral.StrategyPattern;

namespace Design_Pattern.BehavioralCall
{
    internal static class StrategyStore
    {
        public static void validateStrategy()
        {
            Vehicle vehicle = new OffRoadVehicle();
            vehicle.drive();

            Vehicle vehicle1 = new GoodsVehicle();
            vehicle1.drive();
        }
    }
}
