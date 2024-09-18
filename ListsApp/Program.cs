using System.Globalization;
using System.Net;
using System.Security.Cryptography;

namespace ListsApp
{
    internal class Program

    {

        public interface IPaymentProcessor
        {
            void ProcessPayment(decimal amount);
        }

        public class CreditCardProcessor : IPaymentProcessor
        {
            public void ProcessPayment(decimal amount)
            {
                Console.WriteLine("Processing credit card payment of the amount" + amount);
            }
            // Logic for paypal processors
        }
        public class PaypalProcessor : IPaymentProcessor
        {
            public void ProcessPayment(decimal amount)
            {
                Console.WriteLine("Processing paypal payment of the amount" + amount);
            }
            // Logic for paypal processors
        }

        public class PaymentService
        {
            private readonly IPaymentProcessor _processor;

            public PaymentService(IPaymentProcessor processor)
            {
                _processor = processor;
            }

            public void ProcessPayment(decimal amount) 
            {
                _processor.ProcessPayment(amount);
            }
        }

        static void Main(string[] args)
        {
            // Polymorphism
            IPaymentProcessor creditCardProcessor = new CreditCardProcessor();
            PaymentService paymentService = new PaymentService(creditCardProcessor);
            paymentService.ProcessPayment(100.00m);

            IPaymentProcessor paypalProcessor = new PaypalProcessor();
            paymentService  = new PaymentService(paypalProcessor);
            paymentService.ProcessPayment(85.12m);

            Console.ReadKey();
        }

    }
}
