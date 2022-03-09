using System;

namespace _7_Command
{
    class Program
    {
        static void Main(string[] args)
        {
            //receiver here would be some context/object you want to do something to (e.g. Document)
            Document receiver = new Document(); 

            //command that represents an action
            //Command c = new OpenDocumentCommand(receiver, "pdf"); 

            //use an action to trigger the command 
            //Button b = new Button("Open Document", c);
            //b.Click();
        }
    }
}
