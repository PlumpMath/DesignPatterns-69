using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class ModelDuck : Duck
    {
        public ModelDuck()
        {
            FlyBehavior = new CannotFlyBehavior();
            QuackBehavior = new SqueakBehavior();
        }
        public override void Display()
        {
            Console.WriteLine("---I'm a model duck---");
        }
    }
}
