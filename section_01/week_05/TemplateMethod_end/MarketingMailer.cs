using System;

namespace _5_TemplateMethod
{
    public class MarketingMailer
    {
        //this is our template method
        public void SendAllEmails()
        {
            //the primitive parts of the algorithm
            SendToUsers();
            SendToEmployees();
            SendToPublic();
        }

        protected virtual void SendToUsers()
        {
            Console.WriteLine("Sending emails to users.");
        }

        protected virtual void SendToEmployees()
        {
            Console.WriteLine("Sending emails to employees.");
        }

        protected virtual void SendToPublic()
        {
            Console.WriteLine("Sending emails to public.");
        }

    }
}