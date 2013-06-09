using System;

namespace StrategyPattern
{
    public class CannotFlyBehavior : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly :(");
        }
    }
}