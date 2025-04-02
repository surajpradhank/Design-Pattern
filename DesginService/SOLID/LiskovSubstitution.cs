using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignService.SOLID;

public interface IPaymentProcessor
{
    void ProcessPayment(decimal amount);
}


public class CreditCardPayment : IPaymentProcessor
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing credit card payment of ${amount}");
    }
}


public class PayPalPayment : IPaymentProcessor
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing PayPal payment of ${amount}");
    }
}


public class CryptoPayment : IPaymentProcessor
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing crypto payment of ${amount}");
    }
}


public class PaymentService
{
    private readonly IPaymentProcessor _paymentProcessor;

    public PaymentService(IPaymentProcessor paymentProcessor)
    {
        _paymentProcessor = paymentProcessor;
    }

    public void MakePayment(decimal amount)
    {
        _paymentProcessor.ProcessPayment(amount);
    }
}


/*
 Follows LSP 

// Swap payment processors easily
builder.Services.AddSingleton<IPaymentProcessor, CreditCardPayment>(); 
// builder.Services.AddSingleton<IPaymentProcessor, PayPalPayment>();
// builder.Services.AddSingleton<IPaymentProcessor, CryptoPayment>();
 
 */

/*
 Violate LSP

 public class CryptoPayment : IPaymentProcessor
{
    public void ProcessPayment(decimal amount)
    {
        throw new NotImplementedException(); // ❌ Violates LSP (Not all payments are processed the same way)
    }
}

var paymentService = new PaymentService(new CryptoPayment());
paymentService.MakePayment(100);

It throws an exception! The CryptoPayment class cannot substitute IPaymentProcessor without breaking the program.

✔ Fix: Instead of forcing all payment methods to implement IPaymentProcessor, we create a separate interface for unsupported methods.

 */
