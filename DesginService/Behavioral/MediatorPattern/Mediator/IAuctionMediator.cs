using DesignService.Behavioral.MediatorPattern.Colleague;

namespace DesignService.Behavioral.MediatorPattern.Mediator;

public interface IAuctionMediator
{
    void AddBidder(IColleague colleague);
    void PlaceBid(IColleague colleague, int bidAmount);

}
