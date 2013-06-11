using System;

namespace StrategyPattern3.PaymentMethods
{
    public class Paypal : IPaymentMethod
    {
        public string Name { get; set; }

        public Paypal()
        {
            Name = "Paypal";
        }

        public void Pay(decimal amount)
        {
            Console.WriteLine("\tWithdrawal for ${0} from your {1} account", amount, Name);
        }
    }
}