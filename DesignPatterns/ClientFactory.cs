using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DesignPatterns.Structural.Bridge;
using DesignPatterns.Structural.Composite;
using DesignPatterns.Structural.Decorator;
using DesignPatterns.Structural.Proxy;

namespace DesignPatterns
{
    class ClientFactory
    {
        private IClient _client = null;

        public IClient GetClient(string num)
        {
            switch (num)
            {
                case "1":
                    _client = new DecoratorClient();
                    break;
                case "2":
                    _client = new ProxyClient();
                    break;
                case "3":
                    _client = new BridgeClient();
                    break;
                case "4":
                    _client = new CompositeClient();
                    break;
            }
            return _client;
        }
    }
}
