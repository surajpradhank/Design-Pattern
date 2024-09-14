using DesignService.Behavioral.StrategyPattern;
using DesignService.Behavioral.StrategyPattern.Strategy;

namespace DesignService.Behavioral
{
    public class GoodsVehicle : Vehicle
    {
        public GoodsVehicle() : base(new NormalDriveStrategy())
        {
        }
    }
}
