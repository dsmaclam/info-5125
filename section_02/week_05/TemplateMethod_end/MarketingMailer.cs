using System;

namespace _5_TemplateMethod
{
    public class MarketingMailer
    {
        //template method
        //must be public 
        //sets up the order of primitive operations
        public void SendAllEmails()
        {
            SendToUsers();
            SendToEmployees();
            SendToPublic();
        }

        protected virtual void SendToUsers()
        {
            Console.WriteLine("Sending email to users.");
        }

        protected virtual void SendToEmployees()
        {
            Console.WriteLine("Sending email to employees.");
        }

        protected virtual void SendToPublic()
        {
            Console.WriteLine("Sending email to public.");
        }
    }
}