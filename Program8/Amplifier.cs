using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program8
{
    public class Amplifier
    {
        public Tuner Tuner { get; set; }
        public DvdPlayer DvdPlayer { get; set; }
        public CdPlayer CdPlayer { get; set; }

        public Amplifier(Tuner Tuner, DvdPlayer DvdPlayer, CdPlayer CdPlayer)
        {
            this.Tuner = Tuner;
            this.DvdPlayer = DvdPlayer;
            this.CdPlayer = CdPlayer;
        }

        public void On()
        {
            Console.WriteLine("Amplifier on");
        }

        public void Off()
        {
            Console.WriteLine("Amplifier off");
        }

        public void SetCD()
        {
            Console.WriteLine("Setting CD player: " + DvdPlayer);
        }

        public void SetDVD()
        {
            Console.WriteLine("Setting DVD player: " + CdPlayer);
        }

        public void SetStereoSound()
        {
            Console.WriteLine("Stereo mode");
        }

        public void SetSurroundSound()
        {
            Console.WriteLine("Surround sound on");
        }

        public void SetTuner()
        {
            Console.WriteLine("Setting tuner: " + Tuner);
        }

        public void SetVolume(int level)
        {
            Console.WriteLine("Громкость {0}", level);
        }
    }
}
