using System;
using System.Collections.Generic;
using System.Text;

namespace _9_Visitor
{
    internal class Circle : IElement
    {
        float radius;

        public void AcceptVisitor(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public void DoCircleStuff()
        {
            /// ........
        }

    }
}
