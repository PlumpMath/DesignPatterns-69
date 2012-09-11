using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Structural.Decorator
{
    class Component : IComponent
    {
        public string Operation()
        {
            return "I am walking ";
        }
    }
}
