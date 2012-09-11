using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Structural.Bridge
{
    class BridgeClient : BaseClient, IClient
    {
        // Shows an abstraction and two implementations proceeding independently
        public override void Init()
        {
            Display("Bridge Pattern\n");
            Display(new Abstraction (new ImplementationA()).Operation());
            Display(new Abstraction(new ImplementationB()).Operation());
        }
    }
}
