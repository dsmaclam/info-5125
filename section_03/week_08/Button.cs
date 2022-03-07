namespace _7_Command
{
    public class Button
    {
        protected string buttonText;
        protected ICommand command;

        public Button(string text, ICommand com)
        {
            buttonText = text;
            command = com;
        }

        public void Click()
        {
            command.Execute();
        }
    }
}