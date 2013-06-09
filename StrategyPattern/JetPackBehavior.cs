using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class JetPackBehavior : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying with my jet pack!!! :)");
        }
    }
}
