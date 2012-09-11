using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Structural.Decorator
{
    class DecoratorB : IComponent
    {
        private IComponent component;
        public string AddedState = "past the Coffee Shop ";

        public DecoratorB(IComponent c)
        {
            component = c;
        }

        public string Operation()
        {
            string s = component.Operation();
            s += "to school ";
            return s;
        }
        public string AddedBehavior()
        {
            return "and I bought a cappuccino ";
        }
    }
}
