using System;

namespace Proxy_Pattern_Virtual
{
    public class ProxySubject : ISubject
    {
        protected RealSubject subject;

        public void Request()
        {
            Console.WriteLine("Called Request() on ProxySubject");
            if (subject == null)
            {
                subject = new RealSubject();
            }

            subject.Request();
        }
    }
}