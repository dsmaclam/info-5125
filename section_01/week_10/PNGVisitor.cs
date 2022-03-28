using System;
using System.Collections.Generic;
using System.Text;

namespace _9_Visitor
{
    internal class PNGVisitor : IVisitor
    {
        public void Visit(Circle circle)
        {
            Console.WriteLine("Saving circle to png format...");
        }

        public void Visit(Text text)
        {
            Console.WriteLine("Saving text to png format...");
        }
    }
}
