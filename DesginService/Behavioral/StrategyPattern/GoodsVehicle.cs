using DesginService.Behavioral.StrategyPattern;
using DesginService.Behavioral.StrategyPattern.Stratergy;

namespace DesginService.Behavioral
{
    public class GoodsVehicle : Vehicle
    {
        public GoodsVehicle() : base(new NormalDriveStratergy())
        {
        }
    }
}
