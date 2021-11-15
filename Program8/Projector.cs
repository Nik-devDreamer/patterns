using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program8
{
    public class Projector
    {
        public DvdPlayer DvdPlayer { get; set; }

        public Projector(DvdPlayer DvdPlayer)
        {
            this.DvdPlayer = DvdPlayer;
        }

        public void On()
        {
            Console.WriteLine("Projector on");
        }

        public void Off()
        {
            Console.WriteLine("Projector off");
        }

        public void TvMode()
        {
            Console.WriteLine("Projector on TvMode");
        }

        public void WideScreenMode()
        {
            Console.WriteLine("Projector in widescreen mode");
        }
    }
}
