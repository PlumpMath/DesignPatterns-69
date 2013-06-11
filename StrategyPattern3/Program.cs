using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern3.PaymentMethods;

namespace StrategyPattern3
{
    class Program
    {
        static void Main(string[] args)
        {
            var bobby = new Customer("Bobby Smith");

            bobby.SetPaymentMethod(new CreditCard());
            bobby.MakePayment(203.12m);

            bobby.MakePayment(123.01m, new Paypal());

            var jane = new Customer("Jane Doe");
            jane.MakePayment(3m, new ECheck());

            Console.ReadLine();
        }
    }
}
