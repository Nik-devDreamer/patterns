using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program7.Adapter
{
    public class WildTurkey
    {
        public void Gobble()
        {
            Console.WriteLine("Gobble gobble");
        }

        public void Fly()
        {
            Console.WriteLine("Flying a short distance");
        }
    }
}
