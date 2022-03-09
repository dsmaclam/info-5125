namespace _7_Command
{
    public class PrintDocumentCommand : ICommand
    {
        private Document reciever;
        
        public PrintDocumentCommand(Document doc)
        {
            reciever = doc;
        }

        public void Execute()
        {
            reciever.Print();
        }
    }
}