using System;
using System.Collections.Generic;
using System.Text;

namespace _9_Visitor
{
    internal class PNGVisitor : IVisitor
    {
        public void Visit(Circle circle)
        {
            Console.WriteLine("saving circle with radius: " + 
                circle.getRadius() + " in png format...");
        }

        public void Visit(Text text)
        {
            Console.WriteLine("saving text in png format...");
        }
    }
}
