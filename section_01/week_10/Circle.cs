using System;
using System.Collections.Generic;
using System.Text;

namespace _9_Visitor
{
    internal class Circle : IElement
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
