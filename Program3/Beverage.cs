using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program3
{
    public abstract class Beverage
    {
        public string description;
        public abstract double Cost();

        public virtual string GetDescription()
        {
            return description;
        }
    }
}
