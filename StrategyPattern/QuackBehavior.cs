using System;

namespace StrategyPattern
{
    public class QuackBehavior : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack!!!");
        }
    }
}