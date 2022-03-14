using System;
using System.Collections.Generic;
using System.Text;

namespace _8_CoR
{
    internal class PrintButton : Handler
    {
        public PrintButton(Handler handler)
        {
            successor = handler;
            //helpText = "this is the print button's help text";
        }

        public override void ShowTooltip()
        {
            if(helpText != null && helpText != "")
            {
                Console.WriteLine(helpText);
            }

            successor.ShowTooltip();
        }
    }
}
