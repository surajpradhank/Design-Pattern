namespace DesignService.Behavioral.MediatorPattern.Colleague;

public interface IColleague
{
    void PlaceBid(int bidAmount);
    void ReceiveBidNotification(int bidAmount);
    string GetName();
}
