using System.Text.RegularExpressions;

namespace Proxy_Pattern_Protection
{
    public class ProxyRequest : IRequest
    {
        protected RealRequest realRealRequest;
        protected User user;

        public ProxyRequest(RealRequest rr, User u)
        {
            realRealRequest = rr;
            user = u;
        }

        public string Request(string url)
        {
            if (user.Role == User.Roles.Employee)
            {
                return realRealRequest.Request(url);
            }

            Regex regex = new Regex("^admin[.]");
            if (!regex.IsMatch(url))
            {
                return realRealRequest.Request(url);
            }

            return "Not authorized to view url " + url;
        }
    }
}