using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignService.Structural.AdapterPattern
{
    using System;

    // 1. Define the Target interface (New Payment System interface)
    public interface INewPaymentSystem
    {
        void ProcessPayment(decimal amount, string currency);
    }

    // 2. Define the Adaptee (Old Payment System interface)
    public class OldPaymentSystem
    {
        public void MakePayment(decimal amount, string paymentType)
        {
            Console.WriteLine($"Payment of {amount} {paymentType} processed by the Old Payment System.");
        }
    }

    // 3. Create an Adapter class that makes the Old System compatible with the New System
    public class PaymentAdapter : INewPaymentSystem
    {
        private OldPaymentSystem _oldPaymentSystem;

        public PaymentAdapter(OldPaymentSystem oldPaymentSystem)
        {
            _oldPaymentSystem = oldPaymentSystem;
        }

        public void ProcessPayment(decimal amount, string currency)
        {
            // Convert the new system's request into the old system's request format
            string paymentType = currency == "USD" ? "Credit Card" : "Bank Transfer"; // Adapt currency to old system format
            _oldPaymentSystem.MakePayment(amount, paymentType);
        }
    }

    // 4. Client code (e-commerce platform) interacts with the New Payment System interface
    class Program
    {
        static void Main(string[] args)
        {
            // Old payment system (legacy)
            OldPaymentSystem oldPaymentSystem = new OldPaymentSystem();

            // Adapter that allows the new system to use the old system
            INewPaymentSystem paymentAdapter = new PaymentAdapter(oldPaymentSystem);

            // E-commerce platform processing a payment using the new system interface
            paymentAdapter.ProcessPayment(100.50m, "USD");
        }
    }

}
