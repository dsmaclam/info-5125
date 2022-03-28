using System;

namespace _9_Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            IElement componentA = new Circle();
            IElement componentB = new Circle();
            IElement componentC = new Text();

            IVisitor saver = new PNGVisitor();
            //IVisitor saver = new JPEGVisitor();
            componentA.Accept(saver);
            componentB.Accept(saver);
            componentC.Accept(saver);
        }
    }
}
