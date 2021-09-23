using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program3.Drink
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "HouseBlend";
        }

        public override double Cost()
        {
            return 2.35;
        }
    }
}
