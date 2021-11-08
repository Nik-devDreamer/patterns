using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program7.Fly
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Утка летит");
        }
    }
}
