using DesignService.Behavioral.ObserverPattern.Observable;

namespace DesignService.Behavioral.ObserverPattern.Observer;

public class EmailAlertObserverImpl : NotificationAlertObserver
{
    string emailId;
    IStockObservable observable;

    public EmailAlertObserverImpl(string _emailId, IStockObservable _observable)
    {
        emailId = _emailId;
        observable = _observable;
    }

    public void Update()
    {
        sendEmail(emailId, msg: "Product is available hurry up !!");
    }

    private void sendEmail(string emailId, string msg)
    {
        Console.WriteLine($"mail send to : {emailId}");
        //actual logic to send email
    }
}
