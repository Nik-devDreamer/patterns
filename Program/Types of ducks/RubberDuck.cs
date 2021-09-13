using System;
using Program.Swimable;
using Program.Fly;
using Program.Quack;

namespace Program
{
    class RubberDuck : Duck
    {
        public RubberDuck()
            : base(new FlyNoWay(), new RubberDuckQuack(), new Swim_())
        {
        }
    }
}