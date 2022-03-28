using System;
using System.Collections.Generic;
using System.Text;

namespace _9_Visitor
{
    internal class Circle : IElement
    {
        protected int radius = 1;

        public int getRadius() { return radius; }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
