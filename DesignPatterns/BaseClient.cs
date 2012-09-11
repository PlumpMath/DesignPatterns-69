using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns
{
    class BaseClient: IClient
    {
        public virtual void Init()
        {
            throw new NotImplementedException();
        }

        public void Display(string s)
        {
            Console.WriteLine(s);
        }
    }
}
