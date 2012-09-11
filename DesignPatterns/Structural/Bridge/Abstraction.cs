using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Structural.Bridge
{
    class Abstraction
    {
        private IBridge _bridge;
        public Abstraction(IBridge implementation)
        {
            _bridge = implementation;
        }
        public string Operation()
        {
            return "Adstraction" + "<<< BRIDGE >>>> " + _bridge.OperationImp();
        }
    }
}
