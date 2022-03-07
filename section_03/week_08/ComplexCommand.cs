using System;
using System.Collections.Generic;

namespace _7_Command
{
    public class ComplexCommand : ICommand
    {
        private List<ICommand> commands;

        public ComplexCommand(Document doc, string fp)
        {
            commands = new List<ICommand>();

            commands.Add(new OpenDocumentCommand(doc, fp));
            commands.Add(new ExitCommand());
        }

        public void Execute()
        {
            foreach (ICommand command in commands)
            {
                command.Execute();
            }
        }
    }
}