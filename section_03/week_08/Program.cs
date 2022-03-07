using System;
using System.Collections.Generic;



namespace _7_Command
{
    class Program
    {
        static void Main(string[] args)
        {
            //receiver here would be some context/object you want to do something to (e.g. Document)
            Document receiver = new Document(); 

            //command that represents an action
            ICommand c = new OpenDocumentCommand(receiver, "something.pdf");

            //use an action to trigger the command 
            Button b = new Button("Open Document", c);
            //b.Click();

            Button exitButton = new Button("Exit", new ExitCommand());
            //exitButton.Click();

            Button complexButton = new Button("Complex Button", new ComplexCommand(receiver, "somepath.pdf"));
            //complexButton.Click();

            Stack<IUndoableCommand> undoStack = new Stack<IUndoableCommand>();

            List<IUndoableCommand> commands = new List<IUndoableCommand>();
            commands.Add(new ConcreteUndoableCommand(undoStack, "a"));
            commands.Add(new ConcreteUndoableCommand(undoStack, "b"));
            commands.Add(new ConcreteUndoableCommand(undoStack, "c"));


            foreach (IUndoableCommand command in commands)
            {
                command.Execute();
            }

            while (undoStack.Count != 0)
            {
                IUndoableCommand command = undoStack.Pop();
                command.Undo();
            }


        }
    }
}
