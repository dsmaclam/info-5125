using System;
using System.Collections.Generic;
using System.Text;

namespace _8_CoR
{
    internal class DialogBox : Handler
    {
        public DialogBox(Handler handler)
        {
            successor = handler;
            //helpText = "this is the dialog box's help text";
        }

    }
}
