using System;
using System.Collections.Generic;
using System.Text;

namespace _8_CoR
{
    internal class Application : Handler
    {
        public Application(Handler handler)
        {
            successor = handler;
            helpText = "This is the applications help text...";
        }
    }
}
