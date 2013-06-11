namespace StrategyPattern3.PaymentMethods
{
    public interface IPaymentMethod
    {
        string Name { get; set; }
        void Pay(decimal amount);
    }
}