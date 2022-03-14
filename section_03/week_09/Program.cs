using System;

namespace _8_CoR
{
    class Program
    {
        static void Main(string[] args)
        {

            Handler notHandledHandler = new Handler(); //this is to protect from request that are not handled by the CoR
            Application a = new Application(notHandledHandler);
            Window w = new Window(a);
            DialogBox db = new DialogBox(w);
            PrintButton pb = new PrintButton(db);

            pb.ShowTooltip();
        }
    }
}
