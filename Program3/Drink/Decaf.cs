using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program3.Drink
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            description = "Decaf";
        }

        public override double Cost()
        {
            return 2.20;
        }
    }
}
