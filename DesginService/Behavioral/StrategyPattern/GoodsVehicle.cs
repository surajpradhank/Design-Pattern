using DesginService.Behavioral.StrategyPattern;
using DesginService.Behavioral.StrategyPattern.Strategy;

namespace DesginService.Behavioral
{
    public class GoodsVehicle : Vehicle
    {
        public GoodsVehicle() : base(new NormalDriveStrategy())
        {
        }
    }
}
