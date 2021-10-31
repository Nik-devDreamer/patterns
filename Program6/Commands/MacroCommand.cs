using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program6.Commands
{
    public class MacroCommand : ICommand
    {
        private ICommand[] commands;

        public MacroCommand(ICommand[] commands)
        {
            this.commands = commands;
        }

        public void Execute()
        {
            foreach (ICommand com in commands)
            {
                com.Execute();
            }
        }

        public void Undo()
        {
            foreach (ICommand com in commands)
            {
                com.Undo();
            }
        }
    }
}
