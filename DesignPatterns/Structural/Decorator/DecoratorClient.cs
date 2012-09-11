using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Structural.Decorator
{
    class DecoratorClient : BaseClient, IClient
    {
        public override void Init()
        {
            Display("Decorator Pattern\n");

            IComponent component = new Component();
            Display("1. Basic component:\t", component);
            Display("2. A-decorated:\t", new DecoratorA(component)); 
            Display("3. B-decorated:\t", new DecoratorB(new DecoratorA(component)));
            DecoratorB b = new DecoratorB(new Component());
            Display("5. A-B-decorated:\t", new DecoratorA(b));
            Display("\t\t\t"+b.AddedState + b.AddedBehavior());
        }
        public void Display(string s, IComponent c)
        {
            Display(s+c.Operation());
        }
    }
}
