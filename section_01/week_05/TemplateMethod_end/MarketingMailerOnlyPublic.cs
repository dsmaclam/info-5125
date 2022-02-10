using System;

namespace _5_TemplateMethod
{
    public class MarketingMailerOnlyPublic : MarketingMailer
    {
        protected override void SendToUsers()
        {
            //do nothing instead
        }
         
        protected override void SendToEmployees()
        {
            Console.WriteLine("Sending email to public employees.");
        }
    }
}