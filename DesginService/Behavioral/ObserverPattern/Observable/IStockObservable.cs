using DesginService.Behavioral.ObserverPattern.Observer;

namespace DesginService.Behavioral.ObserverPattern.Observable;

public interface IStockObservable
{
    public void add(NotificationAlertObserver observer);
    public void remove(NotificationAlertObserver observer);
    public void notifySubscribers();
    public void setStockCount(int newStockCount);
    public int getStockCount();

}
