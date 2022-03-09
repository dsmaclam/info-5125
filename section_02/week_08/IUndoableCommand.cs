namespace _7_Command
{
    public abstract class IUndoableCommand : ICommand
    {
        public abstract void Execute();

        public abstract void Undo();
    }
}