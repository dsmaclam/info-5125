using System;
using System.Collections.Generic;
using System.Text;

namespace _8_CoR
{
    internal class Handler
    {
        protected Handler successor;
        protected string helpText;

        public virtual void ShowTooltip()
        {
            if(helpText != null && helpText != "")
            {
                Console.WriteLine(helpText);
                return;
            }
            
            if(successor != null)
            {
                successor.ShowTooltip();
                return;
            }

            throw new Exception("No handler for this request.");

        }
    }
}
