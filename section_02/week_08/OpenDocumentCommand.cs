namespace _7_Command
{
    public class OpenDocumentCommand : ICommand
    {
        private Document reciever;
        private string filepath;

        public OpenDocumentCommand(Document doc, string fp)
        {
            reciever = doc;
            filepath = fp;
        }

        public void Execute()
        {
            reciever.Open(filepath);
        }
    }
}