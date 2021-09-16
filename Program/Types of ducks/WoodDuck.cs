using System;
using Program.Swimable;
using Program.Fly;
using Program.Quack;

namespace Program
{
    class WoodDuck : Duck
    {
        public WoodDuck()
            : base(new FlyNoWay(), new NoQuack(), new NoSwim())
        {
        }

        public override void Display()
        {
            Console.WriteLine("���������� ����:");
            base.Display();
        }
    }
}