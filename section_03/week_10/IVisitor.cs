using System;
using System.Collections.Generic;
using System.Text;

namespace _9_Visitor
{
    internal interface IVisitor
    {
        //todo: add methods for each concrete type we want to save
        void Visit(Circle circle);
        void Visit(Text text);
    }
}
