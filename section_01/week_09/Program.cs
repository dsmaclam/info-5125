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

            pb.HandleRequest();

            /*
             *  Try create the DialogBox and PrintButton
             *  with various helpText (empty, null, populated)
             *  
             *  PrintButton override the handle method to show 2 layers 
             *  of helpText
             *  
             *  Take-up @ 11:45AM
             * 
             */

        }
    }
}
