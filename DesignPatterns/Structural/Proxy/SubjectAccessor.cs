using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Structural.Proxy
{
    class SubjectAccessor
    {

        private class Subject : ISubject
        {
            public string Request()
            {
                return "Subject Request " + "Choose Left Door\n";
            }
        }
        public class Proxy: ISubject
        {
            private Subject _subject;
            public string Request()
            {
                // A virtual proxy creates the object only on its first method call
                if(_subject==null)
                {
                    Console.WriteLine("Subject inactive");
                    _subject = new Subject();
                }
                Console.WriteLine("Subject active");
                return "Proxy: Call to " + _subject.Request();
            }
        }
        public class ProtectionProxy : Proxy
        {
            //An authentication proxy first asks for a password
            private Subject _subject;
            private string _password = "Abracadabra";
            public string Authenticate(string supplied)
            {
                if(supplied!=_password)
                {
                    return "Protection Proxy: No Access";
                } 
                else
                {
                    _subject = new Subject();
                    return "Protection Proxy: Authenticated";
                }
            }
            public new string Request()
            {
                if(_subject==null)
                {
                    return "Protection Proxy: Authenticate first";
                } 
                else
                {
                    return "Protection Proxy: Call to " + _subject.Request();
                }
            }
            
        }
    }
}
