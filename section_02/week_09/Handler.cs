using System;
using System.Collections.Generic;
using System.Text;

namespace _8_CoR
{
    internal abstract class Handler
    {
        protected Handler succesor = null; //reference to next handler (if there is on)
        protected string helpText = "";

        public virtual void ShowTooltip()
        {
            //default handling of the request
            if(helpText != null && helpText != "")
            {
                Console.WriteLine(helpText);
                return;
            }

            //if i cannot handle it
            //check for successor handler
            if(succesor != null)
            {
                succesor.ShowTooltip();
                return;
            }

            //otherwise there is not appropriate handler
            //for the request
            throw new Exception("No Handler For Request!!!!");

        }
    }
}
