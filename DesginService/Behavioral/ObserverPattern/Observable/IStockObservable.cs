using DesignService.Behavioral.ObserverPattern.Observer;

namespace DesignService.Behavioral.ObserverPattern.Observable;

public interface IStockObservable
{
    public void Add(NotificationAlertObserver observer);
    public void Remove(NotificationAlertObserver observer);
    public void NotifySubscribers();
    public void SetStockCount(int newStockCount);
    public int GetStockCount();

}
