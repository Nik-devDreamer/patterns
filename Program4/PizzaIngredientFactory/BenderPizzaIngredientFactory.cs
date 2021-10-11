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
    class BenderPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public ICheese CreateCheese()
        {
            return new MozarellaCheese();
        }

        public IDough CreateDough()
        {
            return new ThickCrustDough();
        }

        public IClams CreateClams()
        {
            return new FreshClams();
        }

        public IPepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public List<IVeggies> CreateVeggies()
        {
            return new List<IVeggies>() 
            { 
                new RedPepper(), new Onion() 
            };
        }

        public ISauce CreateSauce()
        {
            return new MarinaraSauce();
        }
    }
}
