using System;
using System.Collections.Generic;
using System.Text;

namespace _9_Visitor
{
    internal interface IVisitor
    {
        void Visit(Circle circle);
        void Visit(Text text);
    }
}
