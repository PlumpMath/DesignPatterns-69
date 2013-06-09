using System;

namespace StrategyPattern
{
    public class MuteBehavior : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("<< Silence >>");
        }
    }
}