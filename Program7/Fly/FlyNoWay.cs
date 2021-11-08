using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program7.Fly
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Данная утка не умеет летать");
        }
    }
}
