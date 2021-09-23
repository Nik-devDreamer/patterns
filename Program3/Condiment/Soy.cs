using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program3.Condiment
{
    public class Soy : CondimentDecorator
    {
        Beverage beverage;
        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double Cost()
        {
            return 1.20 + beverage.Cost();
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + " - Soy";
        }
    }
}
