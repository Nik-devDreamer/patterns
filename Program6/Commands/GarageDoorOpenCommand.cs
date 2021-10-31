using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Program6.Device;

namespace Program6.Commands
{
    public class GarageDoorOpenCommand : ICommand
    {
        private GarageDoor garageDoor;

        public GarageDoorOpenCommand(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }
        public void Execute()
        {
            garageDoor.LightOn();
            garageDoor.Up();
        }

        public void Undo()
        {
            garageDoor.LightOff();
            garageDoor.Down();
        }
    }
}
