namespace _7_Command
{
    public class ExitApplicationCommand : ICommand
    {
        public void Execute()
        {
            System.Environment.Exit(42);
        }
    }
}