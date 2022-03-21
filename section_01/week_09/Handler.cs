using System;
using System.Collections.Generic;
using System.Text;

namespace _8_CoR
{
    internal abstract class Handler
    {
        protected Handler successor;
        protected string helpText;
        
        public virtual void HandleRequest()
        {
            //can i handle the request
            if(helpText != null && helpText != "")
            {
                //YES
                Console.WriteLine(helpText);
                return;
            }

            //NO, do we have a successor
            if(successor != null)
            {
                //pass to successor
                successor.HandleRequest();
                return;
            }

            throw new Exception("no handler for this request");
        }
    }
}
