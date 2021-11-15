using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program8
{
    public class DvdPlayer
    {
        public void On()
        {
            Console.WriteLine("DvdPlayer on");
        }

        public void Off()
        {
            Console.WriteLine("DvdPlayer off");
        }

        public void Eject()
        {
            Console.WriteLine("DVD eject");
        }

        public void Pause()
        {
            Console.WriteLine("Pause");
        }

        public void Play(string title)
        {
            Console.WriteLine("DVD playing: {0}", title);
        }
        public void Stop()
        {
            Console.WriteLine("Stop");
        }
    }
}
