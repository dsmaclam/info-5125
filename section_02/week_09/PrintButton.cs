using System;
using System.Collections.Generic;
using System.Text;

namespace _8_CoR
{
    internal class PrintButton : Handler
    {
        public PrintButton(Handler nextHandler)
        {
            succesor = nextHandler;
            helpText = "Also showing some print button help text...";
        }

        public override void ShowTooltip()
        {
            if(succesor != null)
            {
                succesor.ShowTooltip();
            }

            Console.WriteLine(helpText);
        }
    }
}
