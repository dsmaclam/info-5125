using System;
using System.Collections.Generic;

namespace _7_Command
{
    public class ConcreteUndoableCommand : IUndoableCommand
    {
        private string text;

        public ConcreteUndoableCommand(Stack<IUndoableCommand> stack, string t) : base(stack)
        {

            text = t;
        }

        public override void Execute()
        {
            Console.WriteLine(text);
            
        }

        public override void Undo()
        {
            Console.WriteLine("Undoing " + text);
        }
    }
}