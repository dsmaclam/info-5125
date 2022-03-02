using System;
using System.Threading;

namespace Proxy_Pattern_Virtual
{
    public class RealSubject : ISubject
    {
        public RealSubject()
        {
            Thread.Sleep(5000);
        }

        public void Request()
        {
            Console.WriteLine("Executing the request() on RealSubject");
        }
    }
}