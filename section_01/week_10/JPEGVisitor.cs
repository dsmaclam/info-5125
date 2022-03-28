using System;
using System.Collections.Generic;
using System.Text;

namespace _9_Visitor
{
    internal class JPEGVisitor : IVisitor
    {
        public void Visit(Circle circle)
        {
            Console.WriteLine("Saving circle in jpeg format..");
        }

        public void Visit(Text text)
        {
            Console.WriteLine("Saving text in jpeg format..");
        }
    }
}
