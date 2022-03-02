namespace Proxy_Pattern_Protection
{
    public class RealRequest : IRequest
    {
        public string Request(string url)
        {
            return "Accessing " + url;
        }
    }
}