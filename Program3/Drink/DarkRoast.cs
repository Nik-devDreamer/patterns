using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program3.Drink
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            description = "DarkRoast";
        }

        public override double Cost()
        {
            return 2.40;
        }
    }
}
