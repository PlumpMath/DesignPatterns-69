using System;

namespace StrategyPattern3.PaymentMethods
{
    public class ECheck : IPaymentMethod
    {
        public string Name { get; set; }

        public ECheck()
        {
            Name = "ECheck";
        }

        public void Pay(decimal amount)
        {
            Console.WriteLine("\tAuth ${0} with {1} (Charges will appear on statements 3-5 business days)", amount, Name);
        }
    }
}