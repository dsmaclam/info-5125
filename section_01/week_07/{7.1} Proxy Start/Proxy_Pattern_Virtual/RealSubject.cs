using System;
using System.Threading;

namespace Proxy_Pattern_Virtual
{
    public class RealSubject : ISubject
    {
        public RealSubject()
        {
            Console.WriteLine("Creating instance of RealSubject");
            Thread.Sleep(5000);
        }

        public void Request()
        {
            Console.WriteLine("Called Request() on RealSubject");
        }
    }
}