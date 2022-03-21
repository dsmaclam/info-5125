using System;
using System.Collections.Generic;
using System.Text;

namespace _8_CoR
{
    internal class PrintButton : Handler
    {
        public PrintButton(Handler nextHandler)
        {
            successor = nextHandler;
            helpText = "This is the print button's help text...";
        }

        public override void HandleRequest()
        {
            if(helpText != null && helpText != "")
            {
                Console.WriteLine(helpText);
            }

            if(successor != null)
            {
                successor.HandleRequest();
                return;
            } 
        }
    }
}
