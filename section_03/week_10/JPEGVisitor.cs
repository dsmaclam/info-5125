using System;
using System.Collections.Generic;
using System.Text;

namespace _9_Visitor
{
    internal class JPEGVisitor : IVisitor
    {
        public void Visit(Circle circle)
        {
            Console.WriteLine("Serizlizing the circle to JPEG format...");
        }

        public void Visit(Text text)
        {
            Console.WriteLine("Serializing the text object to JPEG...");
        }
    }
}
