using System;
using System.Collections.Generic;
using System.Text;

namespace _9_Visitor
{
    internal class JPEGVisitor : IVisitor
    {
        public void Visit(Circle circle)
        {
            Console.WriteLine("saving circle with radius: " + circle.getRadius() + " in jpeg format...");
        }

        public void Visit(Text text)
        {
            Console.WriteLine("saving text in jpeg format...");
        }
    }
}
