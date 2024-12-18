using DesignService.Behavioral.ObserverPattern.Observer;

namespace DesignService.Behavioral.ObserverPattern.Observable
{
    public class IphoneObservableImpl : IStockObservable
    {

        private List<NotificationAlertObserver> _observers = new();
        private int stockCount = 0;

        public void Add(NotificationAlertObserver observer)
        {
            _observers.Add(observer);
        }

        public void Remove(NotificationAlertObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifySubscribers()
        {
            foreach (NotificationAlertObserver observer in _observers)
            {
                observer.Update();

            }
        }

        public void SetStockCount(int newStockCount)
        {
            if (stockCount == 0) NotifySubscribers();

            stockCount += newStockCount;
        }

        public int GetStockCount()
        {
            return stockCount;
        }

    }
}
