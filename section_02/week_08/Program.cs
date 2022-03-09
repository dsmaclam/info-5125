using System;
using System.Collections;
using System.Collections.Generic;

namespace _7_Command
{
    class Program
    {
        static void Main(string[] args)
        {
            //receiver here would be some context/object you want to do something to (e.g. Document)
            Document receiver = new Document(); 

            //receiver.Open("something.pdf");

            //command that represents an action
            ICommand c1 = new OpenDocumentCommand(receiver, "something.pdf");

            //use an action to trigger the command 
            Button b1 = new Button("Open Document", c1);
            b1.Click();

            Button p = new Button("Print Document", new PrintDocumentCommand(receiver));
            p.Click();

            Button exitButton = new Button("Exit", new ExitApplicationCommand());
            //exitButton.Click();

            IUndoableCommand a = new PrintLetterCommand('A');
            IUndoableCommand b = new PrintLetterCommand('B');
            IUndoableCommand c = new PrintLetterCommand('C');

            Stack<IUndoableCommand> undoStack = new Stack<IUndoableCommand>();
            a.Execute();
            undoStack.Push(a);

            b.Execute();
            undoStack.Push(b);

            c.Execute();
            undoStack.Push(c);

            //undo the last command
            undoStack.Pop().Undo();

            c.Execute();
            undoStack.Push(c);

            //undo all the commands in the undoStack
            while (undoStack.Count > 0)
            {
                undoStack.Pop().Undo();
            }

        }
    }
}
