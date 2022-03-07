using System.Collections.Generic;

namespace _7_Command
{
    public abstract class IUndoableCommand : ICommand
    {
        private Stack<IUndoableCommand> undoStack;

        public IUndoableCommand(Stack<IUndoableCommand> s)
        {
            undoStack = s;
        }

        public abstract void Undo();

        public virtual void Execute()
        {
            undoStack.Push(this);
        }


    }
}