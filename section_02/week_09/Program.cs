using System;

namespace _8_CoR
{
    class Program
    {
        static void Main(string[] args)
        {
            Application a = new Application();
            Window w = new Window(a);
            DialogBox db = new DialogBox(w);
            PrintButton pb = new PrintButton(db);

            pb.ShowTooltip();
        }
    }
}
