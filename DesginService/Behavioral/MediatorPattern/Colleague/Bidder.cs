using DesignService.Behavioral.MediatorPattern.Mediator;

namespace DesignService.Behavioral.MediatorPattern.Colleague;

public class Bidder : IColleague
{
    string name;
    IAuctionMediator auctionMediator;

    public Bidder(string name, IAuctionMediator auctionMediator)
    {
        this.name = name;
        this.auctionMediator = auctionMediator;
        this.auctionMediator.AddBidder(this);
    }
    public string GetName()
    {
        return name;
    }

    public void PlaceBid(int bidAmount)
    {
        auctionMediator.PlaceBid(this, bidAmount);
    }

    public void ReceiveBidNotification(int bidAmount)
    {
        Console.WriteLine($"Bidder {name} got the notification that someone has placed a bid of : {bidAmount}");
    }
}
