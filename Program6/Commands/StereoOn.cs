using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Program6.Device;

namespace Program6.Commands
{
    public class StereoOn : ICommand
    {
        private Stereo stereo;

        public StereoOn(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void Execute()
        {
            stereo.On();
            stereo.SetCD();
            stereo.SetVolume(10);
        }

        public void Undo()
        {
            stereo.Off();
        }
    }
}
