using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Program6.Commands;

namespace Program6
{
    public class RemoteControl
    {
        ICommand[] onCommands;
        ICommand[] offCommands;
        ICommand undoCommand;

        public RemoteControl()
        {
            onCommands = new ICommand[7];
            offCommands = new ICommand[7];

            ICommand noCommand = new NoCommand();

            for (int i = 0; i < 7; i++)
            {
                onCommands[i] = noCommand;
                offCommands[i] = noCommand;
            }
            undoCommand = noCommand;
        }

        public void SetCommand(int key, ICommand onCommand, ICommand offCommand)
        {
            onCommands[key] = onCommand;
            offCommands[key] = offCommand;
        }

        public void PushOnButton(int key)
        {
            onCommands[key].Execute();
            undoCommand = onCommands[key];
        }

        public void PushOffButton(int key)
        {
            offCommands[key].Execute();
            undoCommand = offCommands[key];
        }

        public void PushUndoButton()
        {
            undoCommand.Undo();
        }
    }
}
