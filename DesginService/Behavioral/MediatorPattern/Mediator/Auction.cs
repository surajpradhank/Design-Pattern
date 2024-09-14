using DesignService.Behavioral.MediatorPattern.Colleague;

namespace DesignService.Behavioral.MediatorPattern.Mediator;

public class Auction : IAuctionMediator
{

    List<IColleague> colleagues = new();
    public void AddBidder(IColleague colleague)
    {
        colleagues.Add(colleague);
    }

    public void PlaceBid(IColleague bidder, int bidAmount)
    {
        foreach (IColleague colleague in colleagues)
        {
            if (!colleague.GetName().Equals(bidder.GetName()))
            {
                colleague.ReceiveBidNotification(bidAmount);
            }
        }
    }
}
