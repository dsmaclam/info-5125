//this program shows the proxy pattern to handle caching data and lazy loading it
using System;

namespace Proxy_Pattern_Virtual
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var proxySubject = new ProxySubject();

            if (new Random().Next(1, 100) % 2 == 0)
            {
                proxySubject.Request();
            }
            
            //proxySubject.Request();
        }
    }
}
