using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program3.Condiment
{
    public class Milk : CondimentDecorator
    {
        Beverage beverage;
        public Milk(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double Cost()
        {
            return 1.50 + beverage.Cost();
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + " - Milk";
        }
    }
}
