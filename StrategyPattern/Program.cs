using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.Display();
            mallard.PerformQuack();
            mallard.PerformFly();

            Duck fauxDuck = new ModelDuck();
            fauxDuck.Display();
            fauxDuck.PerformQuack();
            fauxDuck.PerformFly();

            Duck disabledMallard = new MallardDuck()
                {
                    FlyBehavior = new CannotFlyBehavior(),
                    QuackBehavior = new MuteBehavior()
                };
            disabledMallard.Display();
            disabledMallard.PerformFly();
            disabledMallard.PerformQuack();

            fauxDuck.FlyBehavior = new JetPackBehavior();
            fauxDuck.Display();
            fauxDuck.PerformFly();

            Console.ReadLine();
        }
    }
}
