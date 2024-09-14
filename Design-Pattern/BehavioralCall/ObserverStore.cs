using DesignService.Behavioral.ObserverPattern.Observable;
using DesignService.Behavioral.ObserverPattern.Observer;

namespace Design_Pattern.BehavioralCall;

internal static class ObserverStore
{

    public static void ValidateObserver()
    {
        IStockObservable iPhoneStockObservable = new IphoneObservableImpl();

        NotificationAlertObserver observer1 = new EmailAlertObserverImpl("abc.gmail.com", iPhoneStockObservable);// here iphoneobservable object is passed because user clicked on notifyme for iPhone , if there are other product we can create similar implementation and pass the object similarly
        NotificationAlertObserver observer2 = new EmailAlertObserverImpl("xyz.gmail.com", iPhoneStockObservable);
        NotificationAlertObserver observer3 = new MobileAlertObserverImpl("test_username", iPhoneStockObservable);

        iPhoneStockObservable.add(observer1);
        iPhoneStockObservable.add(observer2);
        iPhoneStockObservable.add(observer3);

        iPhoneStockObservable.setStockCount(10);
    }
}
