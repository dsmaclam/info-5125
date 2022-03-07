using System.Net.Mime;

namespace _7_Command
{
    public class ExitCommand : ICommand
    {
        public void Execute()
        {
            System.Environment.Exit(1);
        }
    }
}