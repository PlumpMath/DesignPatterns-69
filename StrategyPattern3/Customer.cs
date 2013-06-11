using System;
using StrategyPattern3.PaymentMethods;

namespace StrategyPattern3
{
    public class Customer
    {
        public string Name { get; set; }
        protected IPaymentMethod PaymentMethod { get; set; }

        public Customer(string name)
        {
            Name = name;
        }

        public void SetPaymentMethod(IPaymentMethod paymentMethod)
        {
            PaymentMethod = paymentMethod;
        }

        public void MakePayment(decimal amount, IPaymentMethod paymentMethod=null)
        {
            if (paymentMethod != null)
            {
                PaymentMethod = paymentMethod;
            }
            Console.WriteLine("{0} will paid with {1}", Name, PaymentMethod.Name);
            PaymentMethod.Pay(amount);
        }
    }
}