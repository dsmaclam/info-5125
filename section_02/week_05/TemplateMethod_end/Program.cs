using System;

namespace _5_TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            MarketingMailer mm = new MarketingMailer();
            //MarketingMailer mm = new MarketingMailerOnlyPublic();

            //call the common template method
            mm.SendAllEmails();
        }
    }
}
