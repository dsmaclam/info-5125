using System;

namespace _5_TemplateMethod
{
    public class MarketingMailer
    {
        public void SendAllNotifications() 
        {
            SendToUsers();
            SendToEmployees();
            SendToPublic();
        }

        protected virtual void SendToUsers()
        {
            Console.WriteLine("Email sent to users!");
        }

        protected virtual void SendToEmployees()
        {
            Console.WriteLine("Email sent to employees!");
        }

        protected virtual void SendToPublic()
        {
            Console.WriteLine("Email sent to public!");
        }
    }
}