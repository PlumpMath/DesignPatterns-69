using System;

namespace StrategyPattern3.PaymentMethods
{
    public class CreditCard : IPaymentMethod
    {
        public string Name { get; set; }

        public CreditCard()
        {
            Name = "Credit Card";
        }

        public void Pay(decimal amount)
        {
            Console.WriteLine("\tCharged ${0} with {1}", amount, Name);
        }
    }
}