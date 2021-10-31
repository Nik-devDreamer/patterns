using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Program6.Device;

namespace Program6.Commands
{
    public class StereoOff : ICommand
    {
        private Stereo stereo;

        public StereoOff(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void Execute()
        {
            stereo.Off();
        }

        public void Undo()
        {
            stereo.On();
        }
    }
}
