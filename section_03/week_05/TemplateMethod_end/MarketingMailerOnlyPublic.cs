using System;

namespace _5_TemplateMethod
{
    public class MarketingMailerOnlyPublic : MarketingMailer
    {
        protected override void SendToUsers()
        {
        }

        protected override void SendToEmployees()
        {
            Console.WriteLine("Sent to employees that are public only!");
        }
    }
}