using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program3
{
    public abstract class CondimentDecorator : Beverage
    {
        public abstract override double Cost();
    }
}
