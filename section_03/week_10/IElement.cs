using System;
using System.Collections.Generic;
using System.Text;

namespace _9_Visitor
{
    internal interface IElement
    {
        public void AcceptVisitor(IVisitor visitor);
    }
}
