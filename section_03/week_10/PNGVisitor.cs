using System;
using System.Collections.Generic;
using System.Text;

namespace _9_Visitor
{
    internal class PNGVisitor : IVisitor
    {
        public void Visit(Circle circle)
        {
            Console.WriteLine("Serializing the circle object to PNG...");
        }

        public void Visit(Text text)
        {
            Console.WriteLine("Serializing the text object to PNG...");
        }
    }
}
