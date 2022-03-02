using System;

namespace Proxy_Pattern_Virtual
{
    public class ProxySubject : ISubject
    {
        protected RealSubject realSubject;

        public void Request()
        {
            Console.WriteLine("executing request() in ProxySubject");

            if (realSubject == null)
            {
                Console.WriteLine("creating instance of RealSubject");
                realSubject = new RealSubject();
            }

            realSubject.Request();
            Console.WriteLine();
        }
    }
}