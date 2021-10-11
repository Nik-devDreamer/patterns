using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Program4.Cheese;
using Program4.Clams;
using Program4.Dough;
using Program4.Pepperoni;
using Program4.Sauce;
using Program4.Veggies;

namespace Program4.PizzaIngredientFactory
{
    class TiraspolPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public IDough CreateDough()
        {
            return new ThinCrustDough();
        }

        public ICheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        public IClams CreateClams()
        {
            return new FrozenClams();
        }

        public IPepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public List<IVeggies> CreateVeggies()
        {
            return new List<IVeggies>() 
                { 
                    new Mushroom(), new Garlic() 
                };
        }

        public ISauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }
    }
}
