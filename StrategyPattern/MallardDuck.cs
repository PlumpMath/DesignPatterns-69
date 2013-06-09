using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class MallardDuck : Duck
    {
        public MallardDuck()
        {
            FlyBehavior = new FlyWithWingsBehavior();
            QuackBehavior = new QuackBehavior();
        }
        public override void Display()
        {
            Console.WriteLine("---I'm a Mallard Duck---");
        }
    }
}
