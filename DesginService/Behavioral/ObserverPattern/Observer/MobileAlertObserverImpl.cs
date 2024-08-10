using DesginService.Behavioral.ObserverPattern.Observable;

namespace DesginService.Behavioral.ObserverPattern.Observer
{
    public class MobileAlertObserverImpl : NotificationAlertObserver
    {

        private string username;
        IStockObservable observable;

        public MobileAlertObserverImpl(string _username, IStockObservable _observable)
        {
            username = _username;
            observable = _observable;
        }

        public void Update()
        {
            sendmessageOnMobile(username, msg: "product is available hurry up !!");
        }

        private void sendmessageOnMobile(string username, string msg)
        {
            Console.WriteLine($"message sent to: {username}");
            //actual logic send alert
        }
    }
}
