using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Program6.Device;

namespace Program6.Commands
{
    public class CeilingFanHighCommand : ICommand
    {
        private CeilingFan ceilingFan;
        private int prevSpeed;

        public CeilingFanHighCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            prevSpeed = ceilingFan.GetSpeed();
            ceilingFan.High();
        }

        public void Undo()
        {
            if (prevSpeed == ceilingFan.high)
            {
                ceilingFan.High();
            }
            else if (prevSpeed == ceilingFan.medium)
            {
                ceilingFan.Medium();
            }
            else if (prevSpeed == ceilingFan.low)
            {
                ceilingFan.Low();
            }
            else if (prevSpeed == ceilingFan.off)
            {
                ceilingFan.Low();
            }
        }
    }
}
