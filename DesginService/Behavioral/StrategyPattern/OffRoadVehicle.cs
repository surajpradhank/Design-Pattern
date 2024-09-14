using DesignService.Behavioral.StrategyPattern;
using DesignService.Behavioral.StrategyPattern.Strategy;

namespace DesignService.Behavioral
{
    public class OffRoadVehicle : Vehicle
    {
        public OffRoadVehicle() : base(new SpecialDriveStrategy())
        {
        }
    }
}
