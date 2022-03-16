using System;
using System.Collections.Generic;
using System.Text;

namespace _8_CoR
{
    internal class DialogBox : Handler
    {
        public DialogBox(Handler nextHandler)
        {
            succesor = nextHandler;
        }
    }
}
