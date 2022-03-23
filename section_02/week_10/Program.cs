using System;

namespace _9_Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Element componentA = new Circle();
            Element componentB = new Circle();
            Element componentC = new Text();

            // Visitor saver = new PNGVisitor();
            Visitor saver = new JPEGVisitor();
            componentA.Accept(saver);
            componentB.Accept(saver);
            componentC.Accept(saver);
        }
    }
}
