using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program3.Condiment
{
    public class Whip : CondimentDecorator
    {
        Beverage beverage;
        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double Cost()
        {
            return 1.50 + beverage.Cost();
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + " - Whip";
        }
    }
}
