using DesginService.Behavioral.ObserverPattern.Observable;
using DesginService.Behavioral.ObserverPattern.Observer;

namespace Design_Pattern.BehavioralCall;

internal static class ObserverStore
{

    public static void validateObserver()
    {
        IStockObservable iphoneStockObservable = new IphoneObservableImpl();

        NotificationAlertObserver observer1 = new EmailAlertObserverImpl("abc.gmail.com", iphoneStockObservable);// here iphoneobservable object is passed because user clicked on notifyme for iPhone , if there are other product we can create similar implementation and pass the object similarly
        NotificationAlertObserver observer2 = new EmailAlertObserverImpl("xyz.gmail.com", iphoneStockObservable);
        NotificationAlertObserver observer3 = new MobileAlertObserverImpl("test_username", iphoneStockObservable);

        iphoneStockObservable.add(observer1);
        iphoneStockObservable.add(observer2);
        iphoneStockObservable.add(observer3);

        iphoneStockObservable.setStockCount(10);
    }
}
