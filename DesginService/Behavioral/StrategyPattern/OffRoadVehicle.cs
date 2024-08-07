using DesginService.Behavioral.StrategyPattern;
using DesginService.Behavioral.StrategyPattern.Stratergy;

namespace DesginService.Behavioral
{
    public class OffRoadVehicle : Vehicle
    {
        public OffRoadVehicle() : base(new SpecialDriveStratergy())
        {
        }
    }
}
