using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Program7.Swimable;
using Program7.Fly;
using Program7.Quack;

namespace Program7
{
    class WoodDuck : Duck
    {
        public WoodDuck()
            : base(new FlyNoWay(), new NoQuack(), new NoSwim())
        {
        }

        public override void Display()
        {
            Console.WriteLine("Деревянная утка:");
            base.Display();
        }
    }
}
