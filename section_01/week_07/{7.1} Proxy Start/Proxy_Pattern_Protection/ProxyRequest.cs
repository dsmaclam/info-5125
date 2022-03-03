using System.Text.RegularExpressions;

namespace Proxy_Pattern_Protection
{
    public class ProxyRequest : IRequest
    {
        protected RealRequest request;
        public User User { get; set; }

        public ProxyRequest(RealRequest rr, User u)
        {
            request = rr;
            User = u;
        }

        public string Request(string url)
        {
            if(User.Role == User.Roles.Employee)
                return request.Request(url);

            Regex regex = new Regex("^admin[.]");
            if (!regex.IsMatch(url))
            {
                return request.Request(url);
            }

            return "Not Authorized to view " + url;
        }
    }
}