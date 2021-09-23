using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program3.Drink
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            description = "Espresso";
        }

        public override double Cost()
        {
            return 2.50;
        }
    }
}
