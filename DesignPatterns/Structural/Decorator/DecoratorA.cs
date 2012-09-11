using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Structural.Decorator
{
    class DecoratorA : IComponent
    {
        private IComponent component;

        public DecoratorA(IComponent c)
        {
            component = c;
        }

        public string Operation()
        {
            string s = component.Operation();
            s += "and listing to Classic FM ";
            return s;
        }
    }
}
