namespace _7_Command
{
    public class OpenDocumentCommand : ICommand
    {
        protected Document document;
        protected string filePath;

        public OpenDocumentCommand(Document doc, string fp)
        {
            document = doc;
            filePath = fp;
        }

        public void Execute()
        {
            document.Open(filePath);
        }
    }
}