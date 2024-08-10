using DesginService.Behavioral.StrategyPattern;
using DesginService.Behavioral.StrategyPattern.Strategy;

namespace DesginService.Behavioral
{
    public class OffRoadVehicle : Vehicle
    {
        public OffRoadVehicle() : base(new SpecialDriveStrategy())
        {
        }
    }
}
