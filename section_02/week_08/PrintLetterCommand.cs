using System;

namespace _7_Command
{
    public class PrintLetterCommand : IUndoableCommand
    {
        private char letter;

        public PrintLetterCommand(char ch)
        {
            letter = ch;
        }

        public override void Execute()
        {
            Console.WriteLine("printing the letter" + letter);
        }

        public override void Undo()
        {
            Console.WriteLine("deleting the letter" + letter);
        }
    }
}