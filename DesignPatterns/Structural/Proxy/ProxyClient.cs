using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Structural.Proxy
{
    class ProxyClient : BaseClient, IClient
    {
        public override void Init()
        {
            Display("Proxy Pattern\n");

            ISubject subject = new SubjectAccessor.Proxy();
            Display(subject.Request());
            Display(subject.Request());

            subject = new SubjectAccessor.ProtectionProxy();
            Display(subject.Request());


            Display((subject as SubjectAccessor.ProtectionProxy).Authenticate("Secret"));

            Display((subject as SubjectAccessor.ProtectionProxy).Authenticate("Abracadabra"));

            Display(subject.Request());
        }
    }
}
