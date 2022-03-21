using System;
using System.Collections.Generic;
using System.Text;

namespace _8_CoR
{
    internal class Window : Handler
    {
        public Window(Handler nextHandler)
        {
            successor = nextHandler;
            //helpText = "This is the window's help text...";
        }
    }
}
