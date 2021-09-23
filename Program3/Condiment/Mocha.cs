using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program3.Condiment
{
    public class Mocha : CondimentDecorator
    {
        Beverage beverage;
        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double Cost()
        {
            return 1.70 + beverage.Cost();
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + " - Mocha";
        }
    }
}
