using System;
using Program.Swimable;
using Program.Fly;
using Program.Quack;

namespace Program
{
    class RedheadDuck : Duck
    {
        public RedheadDuck()
            : base(new FlyWithWings(), new DuckQuack(), new Swim_())
        {
        }
    }
}