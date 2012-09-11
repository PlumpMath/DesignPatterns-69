using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Structural.Bridge
{
    class ImplementationB:IBridge
    {
        public string OperationImp()
        {
            return "ImplementationB";
        }
    }
}
