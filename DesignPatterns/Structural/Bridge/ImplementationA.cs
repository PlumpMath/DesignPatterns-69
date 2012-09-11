using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Structural.Bridge
{
    class ImplementationA:IBridge
    {
        public string OperationImp()
        {
            return "ImplementationA";
        }
    }
}
