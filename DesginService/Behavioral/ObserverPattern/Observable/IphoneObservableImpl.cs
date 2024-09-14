using DesignService.Behavioral.ObserverPattern.Observer;

namespace DesignService.Behavioral.ObserverPattern.Observable
{
    public class IphoneObservableImpl : IStockObservable
    {

        private List<NotificationAlertObserver> _observers = new();
        private int stockCount = 0;

        public void add(NotificationAlertObserver observer)
        {
            _observers.Add(observer);
        }

        public void remove(NotificationAlertObserver observer)
        {
            _observers.Remove(observer);
        }

        public void notifySubscribers()
        {
            foreach (NotificationAlertObserver observer in _observers)
            {
                observer.Update();

            }
        }

        public void setStockCount(int newStockCount)
        {
            if (stockCount == 0) notifySubscribers();

            stockCount += newStockCount;
        }

        public int getStockCount()
        {
            return stockCount;
        }

    }
}
