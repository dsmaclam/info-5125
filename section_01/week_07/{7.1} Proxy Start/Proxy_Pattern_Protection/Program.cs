using System;

namespace Proxy_Pattern_Protection
{
    class Program
    {
        static void Main(string[] args)
        {
            //lets look at the behaviour for the real request
            RealRequest rr = new RealRequest();
            Console.WriteLine("RealRequest:");
            Console.WriteLine("\t" + rr.Request("testing.com"));
            Console.WriteLine("\t" + rr.Request("admin.testing.com"));

            //lets use our proxy now to control access to the real request
            User user = new User("Bob", User.Roles.Employee);
            User user2 = new User("Sally", User.Roles.Customer);
            ProxyRequest pr = new ProxyRequest(rr, user);
            Console.WriteLine("Employee ProxyRequest:");
            Console.WriteLine("\t" + pr.Request("testing.com"));
            Console.WriteLine("\t" + pr.Request("admin.testing.com"));

            Console.WriteLine("Customer ProxyRequest:");
            pr.User = user2;
            Console.WriteLine("\t" + pr.Request("testing.com"));
            Console.WriteLine("\t" + pr.Request("admin.testing.com"));
        }
    }
}
