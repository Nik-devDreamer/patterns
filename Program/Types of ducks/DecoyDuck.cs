using System;
using Program.Swimable;
using Program.Fly;
using Program.Quack;

namespace Program
{
    class DecoyDuck : Duck
    {
        public DecoyDuck()
            : base(new FlyNoWay(), new NoQuack(), new Swim_())
        {
        }

        public override void Display()
        {
            Console.WriteLine("Ложная утка:");
            base.Display();
        }
    }
}