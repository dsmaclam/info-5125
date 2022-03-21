using System;
using System.Collections.Generic;
using System.Text;

namespace _9_Visitor
{
    internal class Text : IElement
    {
        public void AcceptVisitor(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
