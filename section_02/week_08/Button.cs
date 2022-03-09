namespace _7_Command
{
    public class Button
    {
        private string text;
        private ICommand command;

        public Button(string t, ICommand c)
        {
            text = t;
            command = c;
        }

        public void Click()
        {
            command.Execute();
        }
    }
}